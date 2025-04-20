using CalamityMod.Events;
using CalamityMod.NPCs.Leviathan;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Levi2Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Levi2");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return (NPC.AnyNPCs(ModContent.NPCType<Leviathan>()) || NPC.AnyNPCs(ModContent.NPCType<Anahita>()))
            && !BossRushEvent.BossRushActive;
    }
}
