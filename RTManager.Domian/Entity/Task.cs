﻿using RTManager.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.Domian.Entity
{
    public class Task : BaseEntity
    {
        public int TaskFromRequestId { get; set; }
        public DateTime ConfirmedDeadLine { get; set; }
        public bool IsDone { get; set; }

        public Task(int id, int taskFromRequestId, DateTime confirmedDeadLine, bool isDone)
        {
            Id = id;
            TaskFromRequestId = taskFromRequestId;
            ConfirmedDeadLine = confirmedDeadLine;
            IsDone = isDone;
        }
    }
}
