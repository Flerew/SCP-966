using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.CustomRoles.API.Features;
using Exiled.Loader;
using PlayerRoles;
using System;
using System.Linq;

namespace SCP_966.Playable
{
    [CustomRole(RoleTypeId.Scp0492)]
    public class Scp966 : CustomRole
    {
        public override uint Id { get; set; } = 21;
        public override int MaxHealth { get; set; } = 1950;
        public override string Name { get; set; } = "SCP 966";
        public override string Description { get; set; } = "Invisible scp";
        public override string CustomInfo { get; set; } = "insomniac";
    }
}
