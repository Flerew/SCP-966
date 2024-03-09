using CommandSystem;
using Exiled.API.Features;
using PlayerRoles;
using SCP_966.Playable;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCP_966.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class Scp966 : ICommand
    {
        public string Command { get; } = "spawn966";

        public string[] Aliases { get; } = { "spawnSCP966", "966spawn"};

        public string Description { get; } = "Spawn a random player or you as scp966";

        private Methods methods = new Methods();

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count > 0 && arguments.Array[1] == "me")
            {
                Player player = Player.Get(((CommandSender)sender).SenderId);
                methods.TrySpawn966(player);
                response = "You have spawned as scp966";
                return true;
            }
            else
            {
                methods.TrySpawn966();
                response = "A random player has spawned as scp966";
                return true;
            }
        }
    }
}
