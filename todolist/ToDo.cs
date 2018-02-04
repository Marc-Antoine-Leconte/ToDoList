using System;

namespace todolist
{
    /// <summary>
    /// Define the different status of a task
    /// </summary>
    enum STATUS
    {
        TODO = 0,
        IN_PROGRESS = 1,
        WAITING_VALIDATION = 2,
        DONE = 3
    };

    /// <summary>
    /// Define the different colors of a task
    /// </summary>
    enum COLOR
    {
        WHITE = 0,
        RED = 1,
        GREEN = 2,
        BLUE = 3,
        YELLOW = 4
    };

    /// <summary>
    /// A ToDo is a task in the todolist
    /// </summary>
    class ToDo
    {
        string _title; ///> the title of the task
        string _description; ///> the description of the task
        DateTime _start; ///> the date when the task where done
        DateTime _end; ///> the date when the task should end
        STATUS _status; ///> the current status of the task
        COLOR _color; ///> the color of the task

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Start { get => _start; set => _start = value; }
        public DateTime End { get => _end; set => _end = value; }
        public STATUS Status { get => _status; set => _status = value; }
        public COLOR Color { get => _color; set => _color = value; }

        /// <summary>
        /// Constructor of the ToDo class
        /// Create a todo object
        /// </summary>
        /// <param name="title">The title of the task</param>
        /// <param name="description">The description of the task</param>
        /// <param name="start">The date when the task was created</param>
        /// <param name="end">The date when the task should end</param>
        /// <param name="status">The current status of the task</param>
        /// <param name="color">The color of the task</param>
        public ToDo(string title, string description, DateTime start, DateTime end, STATUS status, COLOR color)
        {
            _title = title;
            _description = description;
            _start = start;
            _end = end;
            _status = status;
            _color = color;
        }
    }
}
