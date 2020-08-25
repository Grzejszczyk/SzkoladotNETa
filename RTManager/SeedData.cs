using RTManager.App.Concrete;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTManager
{
    public class SeedData
    {
        //This is example data. Do not use SeedData class after development state.

        private RequestService _requestService;
        private TaskSevice _taskService;
        private UserService _userService;
        public SeedData(RequestService requestService, UserService userService, TaskSevice taskSevice)
        {
            _userService = userService;
            _requestService = requestService;
            _taskService = taskSevice;
        }
        public void SeedExampleDataUS()
        {
            _userService.AddItem(new User(1, "Łukasz"));
            _userService.AddItem(new User(2, "Kasia"));
            _userService.AddItem(new User(3, "Stanisław"));
            _userService.AddItem(new User(4, "Waleria"));
        }
        public void SeedExampleDataRS()
        {
            _requestService.AddItem(new Request(1, 1, "Zrobić pracę domową dla Szkoła dotNETa.", DateTime.Today.AddDays(2)));
            _requestService.AddItem(new Request(2, 2, "Zrobić kawę.", DateTime.Today.AddDays(3)));
            _requestService.AddItem(new Request(3, 1, "Odkurzyć.", DateTime.Today.AddDays(1)));
            _requestService.AddItem(new Request(4, 2, "Wysłać raporty", DateTime.Today.AddDays(0)));
            _requestService.AddItem(new Request(5, 1, "Odpocząć.", DateTime.Today.AddDays(1)));
        }

        public void SeedExampleDataTS()
        {
            _taskService.AddItem(new Task(1, 1, DateTime.Now.AddDays(2), false));
            _taskService.AddItem(new Task(2, 2, DateTime.Now.AddDays(2), false));
            _taskService.AddItem(new Task(3, 3, DateTime.Now.AddDays(2), false));
            _taskService.AddItem(new Task(4, 4, DateTime.Now.AddDays(0), true));
        }
        public void AllRequests()
        {
            Console.WriteLine();
            Console.WriteLine("See blow all requestes:");
            Console.WriteLine();
            foreach (var item in _requestService.Items)
            {
                Console.WriteLine(item.Id + " " + item.RequestDescription + " Request to: " + item.RequestToUser + " Requested Deadline: " + item.RequestedDeadLine + " Is Assigned? " + item.IsAssignedAsTask);
            }
        }
        public void AllTasks()
        {
            Console.WriteLine();
            Console.WriteLine("See blow all tasks:");
            Console.WriteLine();
            foreach (var item in _taskService.Items)
            {
                Console.WriteLine(item.Id + " Task from request: " + item.TaskFromRequestId + " Is done? " + item.IsDone);
                Console.WriteLine("Description from request: " + _requestService.Items.Where(r => r.Id == item.Id).FirstOrDefault().RequestDescription);
            }
        }
        public void AllUsers()
        {
            Console.WriteLine();
            Console.WriteLine("See blow all users:");
            Console.WriteLine();
            foreach (var item in _userService.Items)
            {
                Console.WriteLine(item.UserName);
            }
        }
    }
}
