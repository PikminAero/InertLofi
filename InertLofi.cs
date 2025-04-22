using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Init Harmony
            Harmony harmony = new Harmony("com.inertlofi.harmony");
            harmony.PatchAll();
            Harmony.DEBUG = true;
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}
