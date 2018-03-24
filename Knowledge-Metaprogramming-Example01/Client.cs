using System;


namespace Knowledge.Metaprogramming.Example01
{
    public class Client
    {
        public string Id   { get; private set; }
        public string Name { get; set; }


        public Client(string id, string name)
        {
            this.Id   = id;
            this.Name = name;
        }


        override public string ToString()
        {
            return String.Format("{0}({1}, {2})", this.GetType().Name, Id, Name);
        }
    }
}
