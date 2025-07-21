using CalamityMod.Events;
using CalamityMod.NPCs.Polterghast;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class WallOfFleshScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/WallOfFlesh");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;
    public override float GetWeight(Player player)
    {
        return 1f;
    }

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(NPCID.WallofFlesh) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceWallOfFlesh
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
