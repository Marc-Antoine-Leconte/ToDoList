using OneNoteServiceSamplesWinUniversal.OneNoteApi;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using System.Linq;
using System;

namespace todolist
{
    /// <summary>
    /// The main page of the application
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string _graphAPIEndpoint = "https://graph.microsoft.com/v1.0/me"; ///> the entry point for the MS authentification
        string _oneNoteEndPoint = "https://graph.microsoft.com/v1.0/me/onenote/pages"; /// the entry point to get the MS onenote pages
        string[] _scopes = new string[] { "user.read", "notes.create", "notes.read", "notes.read.all", "notes.readwrite", "notes.readwrite.all", "notes.readwrite.createdbyapp"}; ///> the scope of authentification asked to the user

        public MainPage()
        {
            this.InitializeComponent();
            Managers.Instance.db.LoadDb();
            foreach (var it in Managers.Instance.taskList)
                ListToDo.Items.Add(it.Title);
        }

        /// <summary>
        /// Permit the connexion to MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MSConnexion(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "";
            AuthenticationResult authResult = null;

            try
            {
                authResult = await App.PublicClientApp.AcquireTokenSilentAsync(_scopes, App.PublicClientApp.Users.FirstOrDefault());
            }
            catch (MsalUiRequiredException ex)
            {
                System.Diagnostics.Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                try
                {
                    authResult = await App.PublicClientApp.AcquireTokenAsync(_scopes);
                }
                catch (MsalException msalex)
                {
                    ResultText.Text = $"Error Acquiring Token:{System.Environment.NewLine}{msalex}";
                }
            }
            catch (Exception ex)
            {
                ResultText.Text = $"Error Acquiring Token Silently:{System.Environment.NewLine}{ex}";
                return;
            }

            if (authResult != null)
            {
                ResultText.Text = "";
                await Managers.Instance.onenote.GetHttpContentWithToken(_graphAPIEndpoint, authResult.AccessToken);
                DisplayUserName(authResult);
                this.SignOutButton.Visibility = Visibility.Visible;
                ConnectOneNote();
            }
        }

        /// <summary>
        /// Deconnect the user from MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSDeconnexion(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "";
            if (App.PublicClientApp.Users.Any())
            {
                try
                {
                    App.PublicClientApp.Remove(App.PublicClientApp.Users.FirstOrDefault());
                    this.ResultText.Text = "User has signed out";
                    this.CallGraphButton.Visibility = Visibility.Visible;
                    this.SignOutButton.Visibility = Visibility.Collapsed;

                    TokenInfoText.Text = "";
                    Managers.Instance.user.Name = "Gest";
                    Managers.Instance.user.UserName = "";
                    Managers.Instance.user.AccessToken = "";
                    TokenInfoText.Text += Managers.Instance.user.Name + Environment.NewLine;
                }
                catch (MsalException ex)
                {
                    ResultText.Text = $"Error signing out user: {ex.Message}";
                }
            }
            Managers.Instance.db.SaveDb();
        }

        /// <summary>
        /// Display UserName after a connection
        /// </summary>
        /// <param name="authResult"></param>
        private void DisplayUserName(AuthenticationResult authResult)
        {
            TokenInfoText.Text = "";
            if (authResult != null)
            {
                Managers.Instance.user.Name = authResult.User.Name;
                Managers.Instance.user.UserName = authResult.User.DisplayableId;
                Managers.Instance.user.AccessToken = authResult.AccessToken;

            }
            TokenInfoText.Text += Managers.Instance.user.Name + Environment.NewLine;
            TokenInfoText.Text += Managers.Instance.user.UserName + Environment.NewLine;
        }

        /// <summary>
        /// Load Notes from MS onenote 
        /// </summary>
        private async void ConnectOneNote()
        {
            COLOR color = COLOR.WHITE;
            STATUS status = STATUS.TODO;
            string description = "";
            int pos1 = 0;
            int pos2 = 0;

            ResultText.Text = "";
            var sectionList = await Managers.Instance.onenote.GetHttpContentWithToken(_oneNoteEndPoint, Managers.Instance.user.AccessToken);
            List <ApiBaseResponse> data = sectionList as List<ApiBaseResponse>;
            if (data == null)
                ResultText.Text += sectionList as string;
            else
            {
                foreach (var it in data)
                {
                    color = COLOR.WHITE;
                    status = STATUS.TODO;

                    PageResponse page = it as PageResponse;
                    var content = await Managers.Instance.onenote.GetHttpContentWithToken(page.ContentUrl, Managers.Instance.user.AccessToken, true);
                    description = content as string;
                    
                    if ((pos1 = description.IndexOf("COLOR=")) != -1 && (pos2 = description.IndexOf(";", pos1)) != -1)
                    {
                        var tmp = description.Substring(pos1 + 6, pos2 - pos1 - 6);
                        for (var i = 0; i < 5; ++i)
                        {
                            COLOR color_ = (COLOR)i;
                            if (color_.ToString() == tmp)
                            {
                                color = (COLOR)i;
                                description = description.Substring(0, pos1) + description.Substring(pos2 + 1);
                                break;
                            }
                        }
                    }

                    if ((pos1 = description.IndexOf("STATUS=")) != -1 && (pos2 = description.IndexOf(";", pos1)) != -1)
                    {
                        var tmp = description.Substring(pos1 + 7, pos2 - pos1 - 7);
                        for (var i = 0; i < 4; ++i)
                        {
                            STATUS status_ = (STATUS)i;
                            if (status_.ToString() == tmp)
                            {
                                status = (STATUS)i;
                                description = description.Substring(0, pos1) + description.Substring(pos2 + 1);
                                break;
                            }
                        }
                    }

                    if (Managers.Instance.AddToDo(page.Title, description, DateTime.Now, DateTime.Now, status, color))
                        ListToDo.Items.Add(page.Title);
                }
            }
            Managers.Instance.db.SaveDb();
        }

        /// <summary>
        /// Open the Pop Up allowing the edition of a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPopUp(object sender, ItemClickEventArgs e)
        {
            var id = e.ClickedItem.ToString();

            foreach (var it in Managers.Instance.taskList)
            {
                if (id == it.Title)
                {
                    Title.Text = it.Title;
                    Status.SelectedIndex = (int)it.Status;
                    Description.Text = Managers.Instance.HtmlDecode(it.Description);
                    End.Date = it.End;
                    Color.SelectedIndex = (int)it.Color;

                    filter.Visibility = Visibility.Visible;
                    Popup_edit.IsOpen = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Open Pop up for a creation of a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPopUp(object sender, RoutedEventArgs e)
        {
            Title.Text = "";
            Status.SelectedIndex = 0;
            Description.Text = "";
            End.Date = DateTime.Now;
            Color.SelectedIndex = 0;

            filter.Visibility = Visibility.Visible;
            Popup_edit.IsOpen = true;
        }

        /// <summary>
        /// Delete a todo task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToDo(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            foreach (var it in Managers.Instance.taskList)
            {
                if (button.Name == it.Title)
                {
                    Managers.Instance.taskList.Remove(it);
                    ListToDo.Items.Remove(button.Name);
                    return;
                }
            }
            Managers.Instance.db.SaveDb();
        }

        /// <summary>
        /// Close the pop up and update or create a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosePopUp(object sender, RoutedEventArgs e)
        {
            if (Title.Text == null || Title.Text == "")
                return;

            foreach (var it in Managers.Instance.taskList)
            {
                if (Title.Text == it.Title)
                {
                    it.Title = Title.Text;
                    it.Status = (STATUS)Status.SelectedIndex;
                    it.Description = Description.Text;
                    it.End = End.Date.Value.DateTime;
                    it.Color = (COLOR)Color.SelectedIndex;

                    filter.Visibility = Visibility.Collapsed;
                    Popup_edit.IsOpen = false;
                    Managers.Instance.db.SaveDb();
                    return;
                }
            }

            Managers.Instance.AddToDo(Title.Text, Description.Text, DateTime.Now, End.Date.Value.DateTime, (STATUS)Status.SelectedIndex, (COLOR)Color.SelectedIndex);
            var choose = Filter.SelectedIndex;

            if (choose == 0)
                ListToDo.Items.Add(Title.Text);
            else
            {
                if ((int)Color.SelectedIndex == choose - 1)
                    ListToDo.Items.Add(Title.Text);
            }
            filter.Visibility = Visibility.Collapsed;
            Popup_edit.IsOpen = false;
            Managers.Instance.db.SaveDb();
        }

        /// <summary>
        /// Read a text with a synthesis voice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ReadText(object sender, RoutedEventArgs e)
        {
            string text = "Description not found";

            if (Description.Text != "")
                text = Description.Text;

            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        /// <summary>
        /// Redisplay all the tasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadList(object sender, SelectionChangedEventArgs e)
        {
            var choose = Filter.SelectedIndex;

            ListToDo.Items.Clear();
            foreach (var it in Managers.Instance.taskList)
            {
                if (choose == 0)
                    ListToDo.Items.Add(it.Title);
                else if ((int)it.Color == choose - 1)
                    ListToDo.Items.Add(it.Title);
            }
        }

        /// <summary>
        /// Exit pop up without saving anything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitPopUp(object sender, RoutedEventArgs e)
        {
            filter.Visibility = Visibility.Collapsed;
            Popup_edit.IsOpen = false;
        }
    }
}
