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

        public override void PostSetupContent()
        {
            var EventCollection = CalamityMod.Systems.MusicEventSystem.EventCollection;
            EventCollection.RemoveAll(e => true);
            MusicEventEntry entry = new MusicEventEntry(
                "CloneDefeated_Lofi",
                MusicLoader.GetMusicSlot(Instance, "Assets/Music/Interlude1"),
                TimeSpan.FromSeconds(146),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => DownedBossSystem.downedCalamitasClone, 
                () => CalamityConfig.Instance.Interlude1
            );
            MusicEventEntry entry2 = new MusicEventEntry(
                "MLDefeated_Lofi",
                MusicLoader.GetMusicSlot(Instance, "Assets/Music/Interlude2"),
                TimeSpan.FromSeconds(204),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => NPC.downedMoonlord,
                () => CalamityConfig.Instance.Interlude2
            );
            MusicEventEntry entry3 = new MusicEventEntry(
                "YharonDefeated_Lofi",
                MusicLoader.GetMusicSlot(Instance, "Assets/Music/Interlude3"),
                TimeSpan.FromSeconds(198),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => DownedBossSystem.downedYharon,
                () => CalamityConfig.Instance.Interlude3
            );
            MusicEventEntry entry4 = new MusicEventEntry(
                "YharonDefeated_Lofi",
                MusicLoader.GetMusicSlot(Instance, "Assets/Music/DevourerofGodsEulogy"),
                TimeSpan.FromSeconds(213),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => DownedBossSystem.downedDoG,
                () => CalamityConfig.Instance.DevourerofGodsEulogy
            );
            MusicEventEntry entry5 = new MusicEventEntry(
                "ScalDefeated_Lofi",
                MusicLoader.GetMusicSlot(Instance, "Assets/Music/CalamitasDefeat"),
                TimeSpan.FromSeconds(176),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => CalamityGlobalNPC.SCalAcceptance != -1,
                () => true
            );
            EventCollection.Add(entry);
            EventCollection.Add(entry2);
            EventCollection.Add(entry3);
            EventCollection.Add(entry4);
            EventCollection.Add(entry5);
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}
