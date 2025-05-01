using CalamityMod.Events;
using CalamityMod.NPCs.BrimstoneElemental;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class BrimstoneElementalScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/BrimstoneElemental");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<BrimstoneElemental>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceBrimstoneElemental
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

