using CalamityMod.Events;
using CalamityMod.NPCs.Signus;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class SignusScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Signus");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Signus>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceSignus
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
