using RTManager.App.Common;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTManager.App.Concrete
{
    public class TaskSevice : BaseService<Task>
    {
        public int ChangeTaskStatusAsDone(int taskId)
        {
            Task taskUpdated = Items.FirstOrDefault(t => t.Id == taskId);
            taskUpdated.IsDone = true;
            UpdateItem(taskUpdated);
            return taskId;
        }
    }
}
