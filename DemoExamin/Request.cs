using System;

namespace DemoExamin
{
    public class Request
    {
        public int Number { get; set; }
        public DateTime DateAdded { get; set; }
        public string Equipment { get; set; }
        public string IssueType { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string Status { get; set; }
        public string Responsible { get; set; }
        public string Comments { get; set; }
    }
}
