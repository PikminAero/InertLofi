using CalamityMod.Events;
using CalamityMod.NPCs.AquaticScourge;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class AquaticScourgeScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AquaticScourge");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<AquaticScourgeHead>()) && !BossRushEvent.BossRushActive;
    }
}
