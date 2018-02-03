using OneNoteServiceSamplesWinUniversal.OneNoteApi;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using System.Linq;
using System;


namespace todolist
{
    public sealed partial class MainPage : Page
    {
        string _graphAPIEndpoint = "https://graph.microsoft.com/v1.0/me";
        string _oneNoteEndPoint = "https://graph.microsoft.com/v1.0/me/onenote/pages";
        string[] _scopes = new string[] { "user.read", "notes.create", "notes.read", "notes.read.all", "notes.readwrite", "notes.readwrite.all", "notes.readwrite.createdbyapp"};

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void CallGraphButton_Click(object sender, RoutedEventArgs e)
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
                DisplayBasicTokenInfo(authResult);
                this.SignOutButton.Visibility = Visibility.Visible;
                ConnectOneNote();
            }
        }

        private void SignOutButton_Click(object sender, RoutedEventArgs e)
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
        }

        private void DisplayBasicTokenInfo(AuthenticationResult authResult)
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

        private async void ConnectOneNote()
        {
            ResultText.Text = "";
            var sectionList = await Managers.Instance.onenote.GetHttpContentWithToken(_oneNoteEndPoint, Managers.Instance.user.AccessToken);
            List <ApiBaseResponse> data = sectionList as List<ApiBaseResponse>;
            if (data == null)
                ResultText.Text += sectionList as string;
            else
            {
                foreach (var it in data)
                {
                    PageResponse page = it as PageResponse;
                    //ResultText.Text += "\n " + page.ContentUrl;
                    var content = await Managers.Instance.onenote.GetHttpContentWithToken(page.ContentUrl, Managers.Instance.user.AccessToken, true);
                    //ResultText.Text += "\n content = " + content;

                    Managers.Instance.AddToDo(page.Title, content as string, DateTime.Now, DateTime.Now, STATUS.TODO, COLOR.BLUE);
                    ListToDo.Items.Add(page.Title);
                }
            }
        }

        private void OpenPopUp(object sender, ItemClickEventArgs e)
        {

            var id = e.ClickedItem.ToString();

            foreach (var it in Managers.Instance.taskList)
            {
                if (id == it.Title)
                {
                    Title.Text = it.Title;
                    Status.SelectedIndex = (int)it.Status;
                    Description.Text = HtmlDecode(it.Description);
                    End.Date = it.End;
                    Color.SelectedIndex = (int)it.Color;

                    filter.Visibility = Visibility.Visible;
                    Popup_edit.IsOpen = true;
                    return;
                }
            }
        }

        private string HtmlDecode(string txt)
        {
            int pos1;
            int pos2;
            string ret = txt;
            
            pos1 = ret.IndexOf("<title>");
            pos2 = ret.IndexOf("</title>");
            ret = ret.Substring(0, pos1) + ret.Substring(pos2 + 8);

            while (ret.IndexOf("<") != -1 && ret.IndexOf(">") != -1)
            {
                pos1 = ret.IndexOf("<");
                pos2 = ret.IndexOf(">");
                ret = ret.Substring(0, pos1) + ret.Substring(pos2 + 1);
            }
            return ret;
        }

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
        }

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
        }

        private void ReadText(object sender, RoutedEventArgs e)
        {
            string text = "Description not found";

            if (Description.Text != "")
                text = Description.Text;

            Read(text);
        }

        private async void Read(string text)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

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

        private void SaveToDb()
        {
            /*var DBPath = Application.StartupPath + "\\Test.mdb";

            conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;"
                + "Data Source=" + DBPath);
            conn.Open();
            */
            

            //OleDbCommand cmd = new OleDbCommand();
            //OleDbConnection con = new OleDbConnection(@"Provider =Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().Replace('/', '\\') + "\\todolist.mdb");

            // create a new database connection:
            /*SQLiteConnection sqlite_conn =
              new SQLiteConnection("Data Source=database.sqlite;Version=3;");

            // open the connection:
            SQLiteCommand sqlite_conn.Open();
        */
        }
    }
}
