using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace T2_Homework
{
    static class Program
    {
        static List<Request> requests = new List<Request>();
        static List<Task> tasks = new List<Task>();
        static List<User> users = new List<User>();
        static string userName;
        static string function;

        static void Main(string[] args)
        {

            //seedData - start (Remove after development)
            SeedData seedData = new SeedData();
            users.AddRange(seedData.users);
            requests.AddRange(seedData.requests);
            tasks.AddRange(seedData.tasks);
            //seedData - end

            Welcome();
        }
        static void Welcome()
        {
            Console.WriteLine("Welcome to Request - Task App");
            Console.WriteLine("Please give me your name and press Enter.");
            userName = Console.ReadLine();
            if (users.Where(u => u.UserName == userName).Any())
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Do you want to create new user? Y/N");
                string answerYN = Console.ReadLine();
                if (answerYN == "y" || answerYN == "Y")
                {
                    CreateUser(userName);
                    Console.WriteLine("User added. New name is " + userName);
                    Menu();
                }
                else
                {
                    Welcome();
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("Select function:");
            Console.WriteLine("1 - Show your requests");
            Console.WriteLine("2 - Show your tasks");
            Console.WriteLine("3 - Assign request to task (functionality not implemented yet. Sorry.)");
            Console.WriteLine("4 - Mark task as done");

            Console.WriteLine("5 - List all requests, all users.");
            Console.WriteLine("6 - List all tasks, all users.");
            Console.WriteLine("7 - List all usesers reqistered in app.");
            function = Console.ReadLine();

            switch (function)
            {
                case "1":
                    ShowUserRequests(userName);
                    break;
                case "2":
                    ShowUserTasks(userName);
                    break;
                case "3":
                    Console.WriteLine("Sorry, this option does not work yet.");
                    break;
                case "4":
                    MarkTaskAsDone();
                    break;
                case "5":
                    ShowUserRequests("AllRequests");
                    break;
                case "6":
                    ShowUserTasks("allTasks");
                    break;
                case "7":
                    ShowAllUsers();
                    break;
                default:
                    Console.WriteLine("Sorry, it is not correct number. Try again.");
                    Menu();
                    break;
            }
        }
        static void ShowAllUsers()
        {
            Console.WriteLine("List of all users:");
            foreach (var item in users)
            {
                Console.WriteLine(item.UserName);
            }
            Menu();
        }
        static void ShowUserRequests(string user)
        {
            if (user == "AllRequests")
            {
                Console.WriteLine("List of all requests:");
                foreach (var item in requests)
                {
                    Console.WriteLine();
                    Console.WriteLine("Request created by:   " + item.RequestUser.UserName);
                    Console.WriteLine("Description:   " + item.RequestDescription);
                    Console.WriteLine("The best DeadLine requested:   " + item.RequestedDeadLine);
                    Console.WriteLine("Request sent to:   " + item.RequestToUser);
                    Console.WriteLine("Is assigned as task?:   " + item.IsAssignedAsTask);
                }
            }
            else
            {
                IEnumerable<Request> requestsFiltered = requests.Where(n => n.RequestToUser.UserName == user);
                //In real app we should chceck foreign key (id fields). Upper kind query can kill your bd.
                foreach (var item in requestsFiltered)
                {
                    Console.WriteLine();
                    Console.WriteLine("Request created by:   " + item.RequestUser.UserName);
                    Console.WriteLine("Description:   " + item.RequestDescription);
                    Console.WriteLine("The best DeadLine requested:   " + item.RequestedDeadLine);
                    Console.WriteLine("Request sent to:   " + item.RequestToUser);
                    Console.WriteLine("Is assigned as task?:   " + item.IsAssignedAsTask);
                }
            }
            Menu();
        }
        static void ShowUserTasks(string user)
        {
            if (user == "allTasks")
            {
                Console.WriteLine("List of all tasks (assigned requests):");
                foreach (var item in tasks)
                {
                    Console.WriteLine();
                    Console.WriteLine("Task owner (responsible for this activity):   " + item.TaskFromRequest.RequestToUser.UserName);
                    Console.WriteLine("Requestor:   " + item.TaskFromRequest.RequestUser);
                    Console.WriteLine("Description for task (from request):   " + item.TaskFromRequest.RequestDescription);
                    Console.WriteLine("Confirmed DeadLine" + item.ConfirmedDeadLine);
                    Console.WriteLine("Is done?: " + item.IsDone);
                }
            }
            else
            {
                IEnumerable<Task> requeststasks = tasks.Where(n => n.TaskFromRequest.RequestToUser.UserName == user);
                //In real app we should chceck foreign key (id fields).
                foreach (var item in requeststasks)
                {
                    Console.WriteLine();
                    Console.WriteLine("Task owner (responsible for this activity):   " + item.TaskFromRequest.RequestToUser.UserName);
                    Console.WriteLine("Requestor:   " + item.TaskFromRequest.RequestUser);
                    Console.WriteLine("Description for task (from request):   " + item.TaskFromRequest.RequestDescription);
                    Console.WriteLine("Confirmed DeadLine" + item.ConfirmedDeadLine);
                    Console.WriteLine("Is done?: " + item.IsDone);
                }
            }
            Menu();
        }
        static void CreateUser(string newUser)
        {
            if (!users.Where(u => u.UserName == newUser).Any() && newUser.Length > 3)
            {
                users.Add(new User { UsedId = users.Count, UserName = newUser });
            }
            else
            {
                Console.WriteLine("Sorry, user exist or name lenght is too short (min 3 characters)");
            }
            Menu();
        }
        static void MarkTaskAsDone()
        {
            Console.WriteLine("Below list of your tasks with number, please put no. and prest Enter to mark as done.");
            IEnumerable<Task> requeststasks = tasks.Where(n => n.TaskFromRequest.RequestToUser.UserName == userName);
            //In real app we should chceck foreign key (id fields).
            foreach (var item in requeststasks)
            {
                Console.WriteLine();
                Console.WriteLine("Task ID:   " + item.TaskId);
                Console.WriteLine("Requestor:   " + item.TaskFromRequest.RequestUser);
                Console.WriteLine("Description for task (from request):   " + item.TaskFromRequest.RequestDescription);
            }
            Console.WriteLine();
            Console.WriteLine("Please select task to mark as done.");
            string taskID = Console.ReadLine();
            tasks.Where(t => t.TaskId.ToString() == taskID).FirstOrDefault().IsDone = true;
            Console.WriteLine("Thank you. Signed as done.");
            Menu();
        }
    }
}
