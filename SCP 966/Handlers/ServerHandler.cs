using Exiled.API.Features;
using Exiled.Loader;
using MEC;
using SCP_966.Playable;
using System;

namespace SCP_966.Handlers
{
    internal sealed class ServerHandler
    {
        private Methods methods = new Methods();
        private Config config;

        public void OnRoundStarted()
        {
            if(Loader.Random.Next(100) <= config.SpawnChance)
                Timing.CallDelayed(0.75f, () => { methods.TrySpawn966(); });
        }
    }
}
