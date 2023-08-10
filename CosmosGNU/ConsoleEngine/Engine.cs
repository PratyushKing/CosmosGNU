using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosGNU.ConsoleEngine
{
    public static class Engine
    {
        public static Dictionary<string, Action<string>> _commands = new Dictionary<string, Action<string>>()
        {
            {"alias", ConsoleEngine.Commands.Alias.cAlias }
        };
        public static void Run()
        {
            while (true)
            {
                Console.Write("root@localhost$ ");
                string query = Console.ReadLine();
                if (query != null)
                {
                    HandleQuery(query);
                }
            }
        }

        public static void HandleQuery(string query)
        {
            string command = query.Split(' ')[0];
            if (_commands.Keys.ToArray().Contains(command))
            {
                try
                {
                    _commands[command](query.Substring(command.Length + 1));
                }
                catch
                {
                    Log.Error("Unknown error while executing command " + command);
                }
            }
            else
                Log.Error("Unknown command");
        }
    }
}
