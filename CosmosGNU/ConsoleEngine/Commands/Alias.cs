using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosGNU.ConsoleEngine.Commands
{
    public static class Alias
    {
        private static Dictionary<string, string[]> _aliases = new Dictionary<string, string[]>();
        public static void cAlias(string query)
        {

        }
        public static void LoadAliases(string[] aliases)
        {
            int addedAliases = 0;
            foreach (string alias in aliases)
            {
                int firstEqIndex = alias.IndexOf('=');
                string aliasName = alias.Substring(0, firstEqIndex);
                string aliasCP = alias;
                aliasCP = aliasCP.Substring(firstEqIndex + 1);
                if (!aliasCP.StartsWith('\'') || !aliasCP.EndsWith('\''))
                {
                    Log.Error("Failed loading alias: " + aliasName);
                    continue;
                }
                aliasCP = aliasCP.Substring(1, aliasCP.Length - 2);
                _aliases.Add(aliasName, aliasCP.Split(" && ", StringSplitOptions.None));
                addedAliases++;
            }
        }
    }
}
