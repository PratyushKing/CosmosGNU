using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosGNU
{
    public class Kernel : Sys.Kernel
    {
        public static Sys.FileSystem.CosmosVFS FS;
        public static string OSName = "CosmosGNU";
        public static string OSVersion = "0.1a";
        protected override void BeforeRun()
        {
            try
            {
                FS = new();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS);
                Log.Success("VFS successfully registered!");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        protected override void Run()
        {
            Console.WriteLine("Welcome to the " + OSName + " version " + OSVersion);
            ConsoleEngine.ConsoleEngine.Run();
        }
    }
}
