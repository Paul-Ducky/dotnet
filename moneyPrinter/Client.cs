using System;

namespace moneyPrinter
{
    public class Client
    {
        private uint Id { get; set; }
        private string Name { get; set; }
        private readonly string JoinedOn;
        public string JoinDate
        {
            get { return JoinedOn; }
        }

        public Client(uint Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            this.JoinedOn = DateTime.Now.ToString("d");
        }
    }
}