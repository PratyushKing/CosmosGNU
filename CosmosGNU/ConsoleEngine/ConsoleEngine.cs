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
        public enum Command
        {
            Alias,
            Bg,
            Bind,
            Break,
            Builtin,
            Caller,
            Cd,
            Command,
            Compgen,
            Complete,
            Compopt,
            Coproc,
            Declare,
            Dirs,
            Disown,
            Echo,
            Enable,
            Eval,
            Exec,
            Exit,
            Export,
            Fc,
            Fg,
            Hash,
            Help,
            History,
            Jobs,
            Kill,
            Let,
            Local,
            Logout,
            Mapfile,
            Popd,
            Pushd,
            Printf,
            Pwd,
            Read,
            ReadArr,
            Readonly,
            Return,
            Shift,
            Shopt,
            Source,
            Suspend,
            Time,
            Times,
            Umask,
            Unalias,
            Unset,
            Wait,
            Mkdir,
            Rmdir,
            Ls,
            Touch,
            Rm
        }

        public static void Run()
        {
            while (true)
            {
                Console.Write("root@localhost$ ");
                string query = Console.ReadLine();
                if (query != null)
                {
                    handleQuery(query);
                }
            }
        }

        public static void handleQuery(string query)
        {
            if (query.StartsWith("alias"))
            {
                if (query == "alias")
                {
                    generateHelp(Command.Alias);
                }
                else if (query.StartsWith("alias "))
                {

                } else
                {
                    Log.Error("invalid syntax");
                }
            }
        }

        public static void generateHelp(Command cmd)
        {
            if (cmd == Command.Alias)
            {
                Console.WriteLine("alias Command\nUsed to set an alias for a command, ex: alias CD=\"cd Desktop\".");
                return;
            }
        }
    }
}
