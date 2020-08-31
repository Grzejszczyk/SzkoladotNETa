using RTManager.App.Abstract;
using RTManager.App.Concrete;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RTManager.App.Managers
{
    public class RequestManager
    {
        private readonly RequestService _requestService;

        public RequestManager(RequestService requestService)
        {
            _requestService = requestService;
        }

        public void GetAllRequests()
        {
            List<Request> requests = new List<Request>();
            requests.AddRange(_requestService.GetAllItems());
            foreach (var item in requests)
            {
                Console.WriteLine();
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Description: " + item.RequestDescription);
                Console.WriteLine("Deadline: " + item.RequestedDeadLine);
                Console.WriteLine("To user: " + item.RequestToUser);
                Console.WriteLine("Author: " + item.CreatedById);
                Console.WriteLine("Created: " + item.CreatedDateTime);
                Console.WriteLine();
            }
        }
        public int AssignRequestAsTask()
        {
            int taskId = 0;
            return taskId;
        }
        public int TaskAsDone()
        {
            int taskId = 0;
            return taskId;
        }
        public int AddNewRequest()
        {
            int userId;
            string requestDesctription;
            DateTime deadline;
            int year;
            int month;
            int day;

            Console.WriteLine("Put your user id");
            Int32.TryParse(Console.ReadLine(), out userId);
            Console.WriteLine("Put description of reqest");
            requestDesctription = Console.ReadLine();
            Console.WriteLine("Put deadline [RRRR, next MM, next DD");
            Console.WriteLine("Year:");
            Int32.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("Month:");
            Int32.TryParse(Console.ReadLine(), out month);
            Console.WriteLine("Day:");
            Int32.TryParse(Console.ReadLine(), out day);
            deadline = new DateTime(year, month, day);

            int requestCount = 0;
            if (_requestService.Items.Any())
            { requestCount = _requestService.GetAllItems().Count; }
            else
            { requestCount = 1; }

            Request request = new Request(requestCount + 1, userId, requestDesctription, deadline);
            _requestService.AddItem(request);
            SaveRequestsToXML();
            return request.Id;
        }
        public void RemoveRequestById()
        {
            int requestId;
            string confirm;
            Console.WriteLine("Put your request id: ");
            Int32.TryParse(Console.ReadLine(), out requestId);

            Request requestToRemove = _requestService.Items.Where(i => i.Id == requestId).FirstOrDefault();

            Console.WriteLine("Request: " + requestToRemove.Id);
            Console.WriteLine(requestToRemove.RequestDescription);
            Console.WriteLine("will be removed. Would like to confirm Y / N ?");
            confirm = Console.ReadLine();
            if (confirm == "Y" || confirm == "y")
            {
                _requestService.RemoveItem(requestToRemove);
                Console.WriteLine("Deleted.");
            }
            else Console.WriteLine("Canceled");
        }
        public Request GetRequestById()
        {
            int id;

            if (_requestService.Items.Any())
            {
                Console.WriteLine("Put Request ID.");
                Int32.TryParse(Console.ReadLine(), out id);
                Request request;
                request = _requestService.Items.Where(r => r.Id == id).FirstOrDefault();
                return request;
            }
            else
                Console.WriteLine("Sorry list of request is empty.");
            return null;
        }
        public void SaveRequestsToXML()
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Requests";
            root.IsNullable = true;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Request>), root);

            using StreamWriter sw = new StreamWriter("requests.xml");
            xmlSerializer.Serialize(sw, _requestService.Items);
        }
    }
}
