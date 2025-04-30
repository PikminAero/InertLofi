using CalamityMod.Events;
using CalamityMod.NPCs.OldDuke;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class OldDukeScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/OldDuke");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    public override float GetWeight(Player player)
    {
        return 1f;
    }

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<OldDuke>()) && !BossRushEvent.BossRushActive;
    }
}
