using System.Collections.Generic;
using System.Linq;

namespace DemoExamin
{
    public class RequestManager
    {
        public List<Request> Requests { get; private set; } = new List<Request>();

        public void AddRequest(Request request)
        {
            Requests.Add(request);
        }

        public List<Request> SearchRequests(string searchTerm)
        {
            return Requests
                .Where(r => r.Number.ToString().Contains(searchTerm) ||
                            r.Equipment.Contains(searchTerm) ||
                            r.Client.Contains(searchTerm))
                .ToList();
        }
    }
}
