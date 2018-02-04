using Windows.Storage;
using System.IO;
using System;

namespace todolist
{
    class DbManager
    {
        public async void SaveDb()
        {
            string text = "";
            int tmp;

            foreach (var it in Managers.Instance.taskList)
            {
                text += it.Title + "\n";
                text += it.Description.Length.ToString() + "\n";
                text += it.Description + "\n";
                text += it.Start.ToString() + "\n";
                text += it.End.ToString() + "\n";
                tmp = (int)it.Status;
                text += tmp.ToString() + "\n";
                tmp = (int)it.Color;
                text += tmp.ToString() + "\n";
            }

            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile file = await storageFolder.CreateFileAsync("Save.db", Windows.Storage.CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, text);
        }

        public async void LoadDb()
        {
            bool run = true;
            int pos = 0;
            int size = 0;
            string title = "";
            string description = "";
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            STATUS status = STATUS.TODO;
            COLOR color = COLOR.WHITE;
            string text = "";

            StorageFolder storageFolder =ApplicationData.Current.LocalFolder;
            try
            {
                StorageFile file = await storageFolder.GetFileAsync("Save.db");
                text = await FileIO.ReadTextAsync(file);
            }
            catch (FileNotFoundException)
            {
                return;
            }

            while (run)
            {
                // find title
                if ((pos = text.IndexOf("\n")) < 0)
                    break;
                title = text.Substring(0, pos);
                text = text.Substring(pos + 1);

                // find description size
                if ((pos = text.IndexOf("\n")) < 0)
                    break;
                size = int.Parse(text.Substring(0, pos));
                text = text.Substring(pos + 1);

                // find description
                if ((pos = size) < 0)
                    break;
                description = text.Substring(0, pos);
                text = text.Substring(pos + 1);

                // find start date
                if ((pos = text.IndexOf("\n")) < 0)
                    break;
                start = DateTime.Parse(text.Substring(0, pos));
                text = text.Substring(pos + 1);

                // find end date
                if ((pos = text.IndexOf("\n")) < 0)
                    break;
                end = DateTime.Parse(text.Substring(0, pos));
                text = text.Substring(pos + 1);

                // find status
                if ((pos = text.IndexOf("\n")) < 0)
                    break;
                status = (STATUS)int.Parse(text.Substring(0, pos));
                text = text.Substring(pos + 1);

                // find color
                if ((pos = text.IndexOf("\n")) < 0)
                    break;
                color = (COLOR)int.Parse(text.Substring(0, pos));
                text = text.Substring(pos + 1);

                Managers.Instance.AddToDo(title, description, start, end, status, color);
            }
        }

        public async void ResetDb()
        {
            StorageFile filed = await ApplicationData.Current.LocalFolder.GetFileAsync("Save.db");
           if (filed != null)
           {
               await filed.DeleteAsync();
               return;
           }
        }
    }
}
