using Exiled.API.Interfaces;
using SCP_966.Playable;

namespace SCP_966
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }

        public Scp966 Scp966 { get; set; } = new Scp966();
        public int SpawnChance { get; set; } = 40;
    }
}
