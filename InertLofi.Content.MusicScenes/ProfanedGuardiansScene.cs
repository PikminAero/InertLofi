using CalamityMod.Events;
using CalamityMod.NPCs.ProfanedGuardians;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class ProfanedGuardiansScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/ProfanedGuardians");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return (NPC.AnyNPCs(ModContent.NPCType<ProfanedGuardianCommander>()) || NPC.AnyNPCs(ModContent.NPCType<ProfanedGuardianDefender>())
            || NPC.AnyNPCs(ModContent.NPCType<ProfanedGuardianHealer>()))
            && !BossRushEvent.BossRushActive;
    }
}
