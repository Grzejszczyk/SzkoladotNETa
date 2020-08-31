using RTManager.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RTManager.Domian.Entity
{
    public class Request : BaseEntity
    {
        [XmlElement]
        public int RequestToUser { get; set; } //who you asking for activity
        [XmlElement]
        public string RequestDescription { get; set; }
        [XmlElement]
        public DateTime RequestedDeadLine { get; set; }
        [XmlElement]
        public bool IsAssignedAsTask { get; set; }
        public Request() { }
        public Request(int id, int requestToUser, string requestDescription, DateTime deadLine)
        {
            Id = id;
            RequestToUser = requestToUser;
            RequestDescription = requestDescription;
            RequestedDeadLine = deadLine;
        }
    }
}
