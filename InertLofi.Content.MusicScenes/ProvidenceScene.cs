using CalamityMod.Events;
using CalamityMod.NPCs.Providence;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class ProvidenceScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Providence");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Providence>()) && !BossRushEvent.BossRushActive;
    }
}
