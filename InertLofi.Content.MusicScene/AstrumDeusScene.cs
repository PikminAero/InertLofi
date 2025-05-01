using CalamityMod.Events;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Ravager;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class AstrumDeusScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AstrumDeus");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<AstrumDeusHead>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceAstrumDeus
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

