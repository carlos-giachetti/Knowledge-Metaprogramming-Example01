using System;


namespace Knowledge.Metaprogramming.Example01
{
    public class Engagement
    {
        public Client Client { get; private set; }
        public string Id     { get; private set; }
        public string Name   { get; set; }


        public Engagement(Client client, string id, string name)
        {
            this.Client = client;
            this.Id     = id;
            this.Name   = name;
        }


        override public string ToString()
        {
            return String.Format("{0}({1}, {2}, {3})", this.GetType().Name, Client.ToString(), Id, Name);
        }
    }
}
