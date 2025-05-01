using CalamityMod.Events;
using CalamityMod.NPCs.AstrumAureus;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class AstrumAureusScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AstrumAureus");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<AstrumAureus>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceAstrumAureus
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

