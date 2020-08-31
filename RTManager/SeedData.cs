using Newtonsoft.Json;
using RTManager.App.Concrete;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

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
            if (File.Exists("users.json"))
            {
                _userService.Items.AddRange(GetUsersFromJson());
            }
            else
            {
                _userService.AddItem(new User(1, "Łukasz") { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _userService.AddItem(new User(2, "Kasia") { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _userService.AddItem(new User(3, "Stanisław") { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _userService.AddItem(new User(4, "Waleria") { CreatedById = 1, CreatedDateTime = DateTime.Now });

                string users = JsonConvert.SerializeObject(_userService.Items);
                using StreamWriter sw = new StreamWriter("users.json");
                using JsonWriter writer = new JsonTextWriter(sw);
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, _userService.Items);
            }

        }
        public void SeedExampleDataRS()
        {
            if (File.Exists("requests.xml"))
            {
                _requestService.Items.AddRange(GetRequestsFromXML());
            }
            else
            {
                _requestService.AddItem(new Request(1, 1, "Zrobić pracę domową dla Szkoła dotNETa.", DateTime.Today.AddDays(2))
                { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _requestService.AddItem(new Request(2, 2, "Zrobić kawę.", DateTime.Today.AddDays(3))
                { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _requestService.AddItem(new Request(3, 1, "Odkurzyć.", DateTime.Today.AddDays(1))
                { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _requestService.AddItem(new Request(4, 2, "Wysłać raporty", DateTime.Today.AddDays(0))
                { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _requestService.AddItem(new Request(5, 1, "Odpocząć.", DateTime.Today.AddDays(1))
                { CreatedById = 1, CreatedDateTime = DateTime.Now });

                XmlRootAttribute root = new XmlRootAttribute();
                root.ElementName = "Requests";
                root.IsNullable = true;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Request>), root);

                using StreamWriter sw = new StreamWriter("requests.xml");
                xmlSerializer.Serialize(sw, _requestService.Items);
            }
        }

        public void SeedExampleDataTS()
        {
            if (File.Exists("tasks.xml"))
            {
                _taskService.Items.AddRange(GetTasksFromXML());
            }
            else
            {
                _taskService.AddItem(new Task(1, 1, DateTime.Now.AddDays(2), false) { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _taskService.AddItem(new Task(2, 2, DateTime.Now.AddDays(2), false) { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _taskService.AddItem(new Task(3, 3, DateTime.Now.AddDays(2), false) { CreatedById = 1, CreatedDateTime = DateTime.Now });
                _taskService.AddItem(new Task(4, 4, DateTime.Now.AddDays(0), true) { CreatedById = 1, CreatedDateTime = DateTime.Now });

                XmlRootAttribute root = new XmlRootAttribute();
                root.ElementName = "Tasks";
                root.IsNullable = true;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Request>), root);

                using StreamWriter sw = new StreamWriter("tasks.xml");
                xmlSerializer.Serialize(sw, _requestService.Items);
            }

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
        public List<Request> GetRequestsFromXML()
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Requests";
            root.IsNullable = true;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Request>), root);

            string xml = File.ReadAllText("requests.xml");
            StringReader stringReader = new StringReader(xml);
            var xmlRequests = (List<Request>)xmlSerializer.Deserialize(stringReader);
            return xmlRequests;
        }
        public List<Task> GetTasksFromXML()
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Tasks";
            root.IsNullable = true;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>), root);

            string xml = File.ReadAllText("tasks.xml");
            StringReader stringReader = new StringReader(xml);
            var xmlTasks = (List<Task>)xmlSerializer.Deserialize(stringReader);
            return xmlTasks;
        }
        public List<User> GetUsersFromJson()
        {
            JsonSerializer json = new JsonSerializer();

            using StreamReader streamReader = new StreamReader("users.json");
            List<User> users = (List<User>)json.Deserialize(streamReader, typeof(List<User>));
            return users;
        }
    }
}
