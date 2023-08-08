using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosGNU.ConsoleEngine
{
    public static class ConsoleEngine
    {
        public static void Run()
        {
            while (true)
            {
                Console.Write("root@localhost$ ");
                string query = Console.ReadLine();
            }
        }
    }
}
