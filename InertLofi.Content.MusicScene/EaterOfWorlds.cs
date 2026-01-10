using CalamityMod.Events;
using CalamityMod.NPCs.Bumblebirb;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class EaterOfWorldsScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/EaterOfWorlds");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(NPCID.EaterofWorldsHead) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceEaterOfWorlds
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
