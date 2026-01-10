using CalamityMod.Events;
using CalamityMod.NPCs.Bumblebirb;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class KingSlimeScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/KingSlime");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(NPCID.KingSlime) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceKingSlime
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
