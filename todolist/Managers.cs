﻿using System.Collections.Generic;
using System;

namespace todolist
{
    class Managers
    {
        private static Managers instance;

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
        public List<ToDo> taskList;
        public UserManager user;
        public OneNoteManager onenote;

        private Managers()
        {
            taskList = new List<ToDo>();
            user = new UserManager("Gest", "", "");
            onenote = new OneNoteManager();
        }

        public void AddToDo(string title, string description, DateTime start, DateTime end, STATUS status, COLOR color)
        {
            ToDo NewToDo = new ToDo(title, description, start, end, status, color);
            taskList.Add(NewToDo);
        }
    }
}
