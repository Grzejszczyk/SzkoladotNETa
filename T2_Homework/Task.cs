using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager
{
    public class Task
    {
        public int TaskId { get; set; }
        public Request TaskFromRequest { get; set; }
        public DateTime ConfirmedDeadLine { get; set; }
        public bool IsDone { get; set; }
    }
}
