using Exiled.API.Features;
using Exiled.API.Enums;
using MEC;
using PlayerRoles;
using System;
using System.Linq;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Extensions;
using PlayerRoles.PlayableScps.HumeShield;

namespace SCP_966.Playable
{
    public class Methods
    { 
        private Config config = new Config();
        private Scp966 scp966 = new Scp966();

        public void TrySpawn966(Player player = null)
        {
            try
            {
                if (player == null)
                {
                    player = Player.Get(RoleTypeId.Spectator).ToList().RandomItem();
                }

                scp966.AddRole(player);
                ConfigurePlayer966(ref player);
                if(player.CustomInfo == scp966.CustomInfo)
                {
                    Cassie.MessageTranslated(config.CassieMessage, config.CassieMessage);
                }
            } 
            catch(Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        public void OnInteractingDoors(InteractingDoorEventArgs ev) 
        { 
            if(ev.Player.CustomInfo == scp966.CustomInfo)
            {
                ev.Player.EnableEffect(EffectType.Invisible);
            }
        }

        private void ConfigurePlayer966(ref Player player)
        {
            player.Role.Set(RoleTypeId.Scp0492);
            player.RankName = scp966.Name;
            player.Health = scp966.MaxHealth;
            player.CustomInfo = scp966.CustomInfo;
            player.EnableEffect(EffectType.Invisible);
        }
    }
}
