using CalamityMod.Events;
using CalamityMod.NPCs.Cryogen;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class CryogenScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Cryogen");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Cryogen>()) && !BossRushEvent.BossRushActive;
    }
}
