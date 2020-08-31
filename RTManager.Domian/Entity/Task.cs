using RTManager.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RTManager.Domian.Entity
{
    public class Task : BaseEntity
    {
        [XmlElement]
        public int TaskFromRequestId { get; set; }
        [XmlElement]
        public DateTime ConfirmedDeadLine { get; set; }
        [XmlElement]
        public bool IsDone { get; set; }

        public Task() { }
        public Task(int id, int taskFromRequestId, DateTime confirmedDeadLine, bool isDone)
        {
            Id = id;
            TaskFromRequestId = taskFromRequestId;
            ConfirmedDeadLine = confirmedDeadLine;
            IsDone = isDone;
        }
    }
}
