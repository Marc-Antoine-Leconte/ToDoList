using System.Collections.Generic;
using System;

namespace todolist
{
    /// <summary>
    /// The class manager contains all the data informations and the different managers of the ToDoList
    /// </summary>
    class Managers
    {
        private static Managers instance; ///> this make the class a singleton

        public static Managers Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Managers();
                }
                return instance;
            }
        }
        public List<ToDo> taskList; ///> the List of the tasks
        public UserManager user; ///> informations about the user
        public OneNoteManager onenote; ///> functions for the recuperation of data from onenote
        public DbManager db; ///> functions for the save of the tasks in local

        private Managers()
        {
            taskList = new List<ToDo>();
            user = new UserManager("Gest", "", "");
            onenote = new OneNoteManager();
            db = new DbManager();
        }

        /// <summary>
        /// Create a new Task in the task list
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="status"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public bool AddToDo(string title, string description, DateTime start, DateTime end, STATUS status, COLOR color)
        {
            if (title != "")
            {
                foreach (var it in taskList)
                {
                    if (it.Title == title)
                        return (false);
                }
                ToDo NewToDo = new ToDo(title, description, start, end, status, color);
                taskList.Add(NewToDo);
                return (true);
            }
            return (false);
        }

        /// <summary>
        /// Util function for remove the html balises in the onenote notes
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public string HtmlDecode(string txt)
        {
            int pos1;
            int pos2;
            string ret = txt;

            pos1 = ret.IndexOf("<title>");
            pos2 = ret.IndexOf("</title>");
            if (pos1 >= 0 && pos2 >= 0)
                ret = ret.Substring(0, pos1) + ret.Substring(pos2 + 8);

            while (ret.IndexOf("<") != -1 && ret.IndexOf(">") != -1)
            {
                pos1 = ret.IndexOf("<");
                pos2 = ret.IndexOf(">");
                ret = ret.Substring(0, pos1) + ret.Substring(pos2 + 1);
            }
            return ret;
        }
    }
}
