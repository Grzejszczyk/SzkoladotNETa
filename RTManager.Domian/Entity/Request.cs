using RTManager.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.Domian.Entity
{
    public class Request : BaseEntity
    {
        public int RequestToUser { get; set; } //who you asking for activity
        public string RequestDescription { get; set; }
        public DateTime RequestedDeadLine { get; set; }
        public bool IsAssignedAsTask { get; set; }
        public Request(int id, int requestToUser, string requestDescription, DateTime deadLine)
        {
            Id = id;
            RequestToUser = requestToUser;
            RequestDescription = requestDescription;
            RequestedDeadLine = deadLine;
        }
    }
}
