using RTManager.App.Concrete;
using RTManager.App.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace RTManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool appActive = true;
            UserService userService = new UserService();
            RequestService requestService = new RequestService();
            TaskSevice taskSevice = new TaskSevice();

            MenuManager menuManager = new MenuManager(requestService, taskSevice);

            #region SeedDataTestArea
            //SeedData methods implemented for manual tests.
            SeedData sd = new SeedData(requestService, userService, taskSevice);
            sd.SeedExampleDataUS();
            sd.SeedExampleDataRS();
            sd.SeedExampleDataTS();
            #endregion

            Console.WriteLine("Welcome to Request-Task Program.");
            while (appActive)
            {
                menuManager.GetMenu();
                appActive = menuManager.DoAction();
            }
        }
    }
}
