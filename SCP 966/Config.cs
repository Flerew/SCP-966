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

        public string CassieMessage { get; set; } = ".G2 .G3 SCP 9 6 6 CONTAINED BREACH DETECTED .G6 .G5";
    }
}
