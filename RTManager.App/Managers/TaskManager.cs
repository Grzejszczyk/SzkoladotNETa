using RTManager.App.Concrete;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RTManager.App.Managers
{
    public class TaskManager
    {
        private readonly TaskSevice _taskSevice;
        private readonly RequestService _requestService;

        public TaskManager(TaskSevice taskSevice, RequestService requestService)
        {
            _taskSevice = taskSevice;
            _requestService = requestService;
        }

        public void GetAllTasks()
        {
            List<Task> tasks = new List<Task>();
            tasks.AddRange(_taskSevice.GetAllItems());
            foreach (var item in tasks)
            {
                Console.WriteLine();
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Request Id: " + item.TaskFromRequestId);
                Console.WriteLine("Description from request: " + _requestService.GetItemById(item.TaskFromRequestId).RequestDescription);
                Console.WriteLine("Confirmed deadline: " + item.ConfirmedDeadLine);
                Console.WriteLine("Author: " + item.CreatedById);
                Console.WriteLine("Created: " + item.CreatedDateTime);
                Console.WriteLine("Is Done?: " + item.IsDone);
                Console.WriteLine();
            }
        }
        public void CreateNewTaskFromRequest()
        {

            int requestId;
            int tasksCount;
            string confirmRequestedDeadline;
            DateTime taskDeadLine = new DateTime();
            int confirmedYear;
            int confirmedMonth;
            int confirmedDay;

            Console.WriteLine("Put Request Id and press Enter.");
            Int32.TryParse(Console.ReadLine(), out requestId);
            Request request = _requestService.GetItemById(requestId);

            Console.WriteLine("Reaquested deadline is: " + request.RequestedDeadLine.ToString("dd.MM.yyyy"));
            Console.WriteLine("Would you like to confirm?   Y / N  ?");

            confirmRequestedDeadline = Console.ReadLine();
            if (confirmRequestedDeadline == "y" || confirmRequestedDeadline == "Y")
            {
                taskDeadLine = request.RequestedDeadLine;
            }
            else if ((confirmRequestedDeadline == "n" || confirmRequestedDeadline == "N"))
            {
                Console.WriteLine("Put new deadline for task [RRRR, next MM, next DD");
                Console.WriteLine("Year:");
                Int32.TryParse(Console.ReadLine(), out confirmedYear);
                Console.WriteLine("Month:");
                Int32.TryParse(Console.ReadLine(), out confirmedMonth);
                Console.WriteLine("Day:");
                Int32.TryParse(Console.ReadLine(), out confirmedDay);
                taskDeadLine = new DateTime(confirmedYear, confirmedMonth, confirmedDay);
            }
            else { Console.WriteLine("Sorry, incorrect decision."); }

            tasksCount = _taskSevice.Items.Count;
            Task task = new Task(tasksCount + 1, requestId, taskDeadLine, false);
            _taskSevice.Items.Add(task);

            Console.WriteLine("Task created: ");
            Console.WriteLine("Id is: " + task.Id);
        }
        public void SignTaskAsDone()
        {
            int taskId;
            Console.WriteLine("Put Task Id: ");
            Int32.TryParse(Console.ReadLine(), out taskId);

            if (_taskSevice.Items.Any(t=>t.Id == taskId))
            {
                _taskSevice.ChangeTaskStatusAsDone(taskId);
            } else
            {
                Console.WriteLine("Sorry, wrong task id.");
            }
        }
    }
}
