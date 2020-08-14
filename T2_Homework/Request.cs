using System;
using System.Collections.Generic;
using System.Text;

namespace T2_Homework
{
    public class Request
    {
        public int RequestId { get; set; }
        public User RequestUser { get; set; } //requestor
        public User RequestToUser { get; set; } //who you asking for activity
        public string RequestDescription { get; set; }
        public DateTime RequestedDeadLine { get; set; }
        public bool IsAssignedAsTask { get; set; }
    }
}
