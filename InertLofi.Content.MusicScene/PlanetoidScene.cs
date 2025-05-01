using CalamityMod.Events;
using CalamityMod.NPCs.PlaguebringerGoliath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.InertLofi.Content.MusicScene
{
    public class TileCounter : ModSystem
    {
        public static int DirtStoneMud = 0;

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            DirtStoneMud = tileCounts[TileID.Dirt] + tileCounts[TileID.Stone] + tileCounts[TileID.Mud];
        }
    }

    public class PlanetoidScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Planetoids");

        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override float GetWeight(Player player)
        {
            return 1f;
        }

        public override bool IsSceneEffectActive(Player player)
        {
            return TileCounter.DirtStoneMud > 100 && player.ZoneSkyHeight && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplacePlanetoid
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
    }
}
