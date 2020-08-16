using RTManager.App.Concrete;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager
{
    public class SeedData
    {
        //This is example data. Do not use SeedData class after development state.

        private RequestService _requestService;
        private TaskSevice _taskService;
        private UserService _userService;
        public SeedData(RequestService requestService/*, TaskSevice taskSevice, UserService userService*/)
        {
            _requestService = requestService;
            //_taskService = taskSevice;
            //_userService = userService;
        }
        public void SeedExampleDataUS()
        {
            //dodać przykładowych userów
        }
        public void SeedExampleDataRS()
        {
            _requestService.AddItem(new Request(1, "Zrobić pracę domową dla Szkoła dotNETa.", DateTime.Today.AddDays(2)));
            _requestService.AddItem(new Request(2, "Zrobić kawę.", DateTime.Today.AddDays(3)));
            _requestService.AddItem(new Request(3, "Odkurzyć.", DateTime.Today.AddDays(1)));
            _requestService.AddItem(new Request(4, "Wysłać raporty", DateTime.Today.AddDays(0)));
            _requestService.AddItem(new Request(5, "Odpocząć.", DateTime.Today.AddDays(1)));
        }

        public void SeedExampleDataTS()
        {
            //dodać przykładowe Taski
        }




        //        public List<Request> requests = new List<Request>();
        //        public List<Task> tasks = new List<Task>();
        //        public List<User> users = new List<User>();

        //        public SeedData()
        //        {
        //            users.Add(new User { UsedId = 0, UserName = "Łukasz" });
        //            users.Add(new User { UsedId = 1, UserName = "Kasia" });
        //            users.Add(new User { UsedId = 2, UserName = "Zbyszek" });
        //            users.Add(new User { UsedId = 3, UserName = "Alicja" });

        //            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić pracę domową dla Szkoła dotNETa.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić kawę", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Odkurzyć.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Nakarmić rybki.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });

        //            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today.AddDays(3), IsDone = false, TaskFromRequest = requests[2], TaskId = 0 });
        //            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today, IsDone = true, TaskFromRequest = requests[3], TaskId = 2 });
        //        }

        //        public void SeedUsers()
        //        {
        //            users.Add(new User { UsedId = 0, UserName = "Łukasz" });
        //            users.Add(new User { UsedId = 1, UserName = "Kasia" });
        //            users.Add(new User { UsedId = 2, UserName = "Zbyszek" });
        //            users.Add(new User { UsedId = 3, UserName = "Alicja" }); 
        //        }
        //        public void SeedRequests()
        //        {
        //            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić pracę domową dla Szkoła dotNETa.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić kawę", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Odkurzyć.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Nakarmić rybki.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        //        }
        //        public void SeedTasks()
        //        {
        //            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today.AddDays(3), IsDone = false, TaskFromRequest = requests[2], TaskId = 0 });
        //            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today, IsDone = true, TaskFromRequest = requests[3], TaskId = 1 });
        //}
    }
}
