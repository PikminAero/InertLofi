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
    public class InterludeManager : ModSystem
    {
        private int GetModdedInterlude1()
        {
            if (InertLofiConfig.Instance.UseVCMMInterlude1)
            {
                return MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/VCMMInterlude1");
            }
            else
            {
                return MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Interlude1");
            }
        }

        private int GetModdedInterlude2()
        {
            /*
            if (InertLofiConfig.Instance.UseVCMMInterlude2)
            {
                return MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/VCMMInterlude2");
            }
            else
            */
            {
                return MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Interlude2");
            }
        }
        /*
        public override void OnWorldLoad()
        {
            var original = new List<MusicEventEntry>(CalamityMod.Systems.MusicEventSystem.EventCollection);
            var EventCollection = CalamityMod.Systems.MusicEventSystem.EventCollection;
            EventCollection.RemoveAll(e => true);
            MusicEventEntry entry = new MusicEventEntry(
                "CloneDefeated_Lofi",
                GetModdedInterlude1(),
                TimeSpan.FromSeconds(146),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => DownedBossSystem.downedCalamitasClone,
                () => CalamityClientConfig.Instance.Interludes
            );
            MusicEventEntry entry2 = new MusicEventEntry(
                "MLDefeated_Lofi",
                GetModdedInterlude2(),
                TimeSpan.FromSeconds(204),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => NPC.downedMoonlord,
                () => CalamityClientConfig.Instance.Interludes
            );
            MusicEventEntry entry3 = new MusicEventEntry(
                "YharonDefeated_Lofi",
                MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Interlude3"),
                TimeSpan.FromSeconds(198),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => DownedBossSystem.downedYharon,
                () => CalamityClientConfig.Instance.Interludes
            );
            MusicEventEntry entry4 = new MusicEventEntry(
                "DoGDefeated_Lofi",
                MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/DevourerofGodsEulogy"),
                TimeSpan.FromSeconds(213),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => DownedBossSystem.downedDoG,
                () => CalamityClientConfig.Instance.DevourerofGodsEulogy
            );
            MusicEventEntry entry5 = new MusicEventEntry(
                "ScalDefeated_Lofi",
                MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/CalamitasDefeat"),
                TimeSpan.FromSeconds(176),
                TimeSpan.Zero,
                TimeSpan.Zero,
                () => CalamityGlobalNPC.SCalAcceptance != -1,
                () => true
            );
            if (InertLofiConfig.Instance.ReplaceInterlude1)
            {
                EventCollection.Add(entry);
            }
            else
            {
                EventCollection.Add(original[0]);
            }
            if (InertLofiConfig.Instance.ReplaceInterlude2)
            {
                EventCollection.Add(entry2);
            }
            else
            {
                EventCollection.Add(original[1]);
            }
            if (InertLofiConfig.Instance.ReplaceInterlude3)
            {
                EventCollection.Add(entry3);
            }
            else
            {
                EventCollection.Add(original[2]);
            }
            if (InertLofiConfig.Instance.ReplaceInterlude4)
            {
                EventCollection.Add(entry4);
            }
            else
            {
                EventCollection.Add(original[3]);
            }
            if (InertLofiConfig.Instance.ReplaceInterlude5)
            {
                EventCollection.Add(entry5);
            }
            else
            {
                EventCollection.Add(original[4]);
            };
        }
        */
    }
}
