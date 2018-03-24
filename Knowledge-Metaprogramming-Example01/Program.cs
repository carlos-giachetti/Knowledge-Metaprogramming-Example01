using System;
using System.Collections.Generic;

namespace Knowledge.Metaprogramming.Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            displayProjectName();


            Log log = new Log();

            Client client;
            Engagement engagement;

            client     = new Client("A", "Client A");
            engagement = new Engagement(client, "A1", "Engagement A1");
            log.Add(client)
               .Add(engagement);

            engagement = new Engagement(client, "A2", "Engagement A2");
            log.Add(engagement);

            client     = new Client("B", "Client B");
            engagement = new Engagement(client, "B1", "Engagement B1");
            log.Add(client)
               .Add(engagement);


            displayMsg(log.ToString());
            
            waitForKeyPress();
        }


        private static void displayMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void displayProjectName()
        {
            displayMsg("Knowledge-MetaProgramming-Example01");
            displayMsg("-----------------------------------\n");
        }

        private static void waitForKeyPress()
        {
            displayMsg("\nPress any key to quit this program...");
            Console.ReadKey();
        }
    }
}
