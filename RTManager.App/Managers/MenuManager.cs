using RTManager.App.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.App.Managers
{
    public class MenuManager
    {
        private readonly MenuActionService menuActionService = new MenuActionService();

        private RequestManager _requestManager;
        private TaskManager _taskManager;

        public MenuManager(RequestService requestService, TaskSevice taskSevice)
        {
            _requestManager = new RequestManager(requestService);
            _taskManager = new TaskManager(taskSevice, requestService);
        }
        
        public void GetMenu()
        {
            var userMenu = menuActionService.GetAllItems();
            menuActionService.GetMenuActionByMenuName("UserMenu");
            for (int i = 0; i < userMenu.Count; i++)
            {
                Console.WriteLine($"{userMenu[i].Id}. {userMenu[i].Name}");
            }
            Console.WriteLine("Write 'exit' to close app.");
        }
        public bool DoAction()
        {
            string actionId;
            Console.WriteLine("Please put action menu number.");
            actionId = Console.ReadLine();
            switch (actionId)
            {
                case "1":
                    Console.WriteLine("Requests List:");
                    Console.WriteLine();
                    _requestManager.GetAllRequests();
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Tasks List:");
                    Console.WriteLine();
                    _taskManager.GetAllTasks();
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Assign Request to user as Task (Create Task).");
                    _taskManager.CreateNewTaskFromRequest();
                    break;
                case "4":
                    Console.WriteLine("Sign Task as done.");
                    _taskManager.SignTaskAsDone();
                    break;
                case "5":
                    Console.WriteLine("Create new request.");
                    _requestManager.AddNewRequest();
                    Console.WriteLine();
                    break;
                case "6":
                    Console.WriteLine("Remove request.");
                    Console.WriteLine();
                    _requestManager.RemoveRequestById();
                    break;
                case "exit":
                    return false;
                default:
                    break;
            }
            return true;
        }
    }
}