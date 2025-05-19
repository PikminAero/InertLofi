using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CalamityMod;
using CalamityMod.NPCs;
using CalamityMod.Systems;
using Microsoft.Xna.Framework.Media;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class InertLofiMod : Mod
    {
        internal static InertLofiMod Instance;

        public override void Load()
        {
            Instance = this;
        }


        public override void Unload()
        {
            Instance = null;
        }
    }
}
