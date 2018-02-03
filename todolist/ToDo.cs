using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    enum STATUS
    {
        TODO = 0,
        IN_PROGRESS = 1,
        WAITING_VALIDATION = 2,
        DONE = 3
    };

    enum COLOR
    {
        WHITE = 0,
        RED = 1,
        GREEN = 2,
        BLUE = 3,
        YELLOW = 4
    };

    class ToDo
    {
        string _title;
        string _description;
        DateTime _start;
        DateTime _end;
        STATUS _status;
        COLOR _color;

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Start { get => _start; set => _start = value; }
        public DateTime End { get => _end; set => _end = value; }
        public STATUS Status { get => _status; set => _status = value; }
        public COLOR Color { get => _color; set => _color = value; }

        public string StatusToString
        {
            get
            {
                switch (_status)
                {
                    case STATUS.DONE :
                        return "Done";
                    case STATUS.IN_PROGRESS :
                        return "In Progress";
                    case STATUS.WAITING_VALIDATION:
                        return "Waiting validation";
                    default:
                        return "To Do";
                }
            }
        }

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
