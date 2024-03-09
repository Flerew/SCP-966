using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace SCP_966
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; } = new Plugin();
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.ServerHandler server;
        private Handlers.PlayerHandler player;

        private Plugin() { }

        public override void OnEnabled()
        {
            Config.Scp966.Register();
            RegisteredEvents();

            Log.Info($"{nameof(Plugin)} is enabled");
        }

        public override void OnDisabled()
        {
            CustomRole.UnregisterRoles();
            UnregisteredEvents();
        }

        private void RegisteredEvents()
        {
            player = new Handlers.PlayerHandler();
            server = new Handlers.ServerHandler();

            Server.RoundStarted += server.OnRoundStarted;
        }

        private void UnregisteredEvents()
        {
            Server.RoundStarted -= server.OnRoundStarted;
        }
    }
}
