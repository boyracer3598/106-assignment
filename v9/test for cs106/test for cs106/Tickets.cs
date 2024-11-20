using System;
using System.ComponentModel;

namespace test_2
{
    public class Tickets
    {
        private string name;
        private string type;
        private string description;
        private string priority;
        private string supportReq;
        private string tags;

        public Tickets() { }

        public Tickets(string name, string type, string description, string priority, string supportReq, string tags)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.priority = priority;
            this.supportReq = supportReq;
            this.tags = tags;
        }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}
