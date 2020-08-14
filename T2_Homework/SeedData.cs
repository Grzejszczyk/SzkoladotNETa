using System;
using System.Collections.Generic;
using System.Text;

namespace T2_Homework
{
    public class SeedData
    {
        //This is example data. Do not use SeedData class after development state.

        public List<Request> requests = new List<Request>();
        public List<Task> tasks = new List<Task>();
        public List<User> users = new List<User>();

        public SeedData()
        {
            users.Add(new User { UsedId = 0, UserName = "Łukasz" });
            users.Add(new User { UsedId = 1, UserName = "Kasia" });
            users.Add(new User { UsedId = 2, UserName = "Zbyszek" });
            users.Add(new User { UsedId = 3, UserName = "Alicja" });

            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić pracę domową dla Szkoła dotNETa.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić kawę", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Odkurzyć.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Nakarmić rybki.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });

            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today.AddDays(3), IsDone = false, TaskFromRequest = requests[2], TaskId = 0 });
            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today, IsDone = true, TaskFromRequest = requests[3], TaskId = 2 });
        }

        public void SeedUsers()
        {
            users.Add(new User { UsedId = 0, UserName = "Łukasz" });
            users.Add(new User { UsedId = 1, UserName = "Kasia" });
            users.Add(new User { UsedId = 2, UserName = "Zbyszek" });
            users.Add(new User { UsedId = 3, UserName = "Alicja" });
        }
        public void SeedRequests()
        {
            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić pracę domową dla Szkoła dotNETa.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
            requests.Add(new Request { IsAssignedAsTask = false, RequestDescription = "Zrobić kawę", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Odkurzyć.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
            requests.Add(new Request { IsAssignedAsTask = true, RequestDescription = "Nakarmić rybki.", RequestedDeadLine = DateTime.Today.AddDays(2), RequestId = 0, RequestUser = users[1], RequestToUser = users[0] });
        }
        public void SeedTasks()
        {
            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today.AddDays(3), IsDone = false, TaskFromRequest = requests[2], TaskId = 0 });
            tasks.Add(new Task { ConfirmedDeadLine = DateTime.Today, IsDone = true, TaskFromRequest = requests[3], TaskId = 1 });
        }
    }
}
