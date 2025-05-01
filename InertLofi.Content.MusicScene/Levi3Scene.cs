using CalamityMod.Events;
using CalamityMod.NPCs.Leviathan;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Levi3Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Leviathan");

    public override SceneEffectPriority Priority => (SceneEffectPriority)9;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Leviathan>()) && NPC.AnyNPCs(ModContent.NPCType<Anahita>()) 
            && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceLevi3
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
