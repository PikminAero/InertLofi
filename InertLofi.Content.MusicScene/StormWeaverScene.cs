using CalamityMod.Events;
using CalamityMod.NPCs.StormWeaver;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class StormWeaverScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/StormWeaver");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<StormWeaverHead>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceStormWeaver
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
