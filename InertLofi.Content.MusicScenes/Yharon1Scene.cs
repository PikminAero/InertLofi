using CalamityMod.Events;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.Yharon;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Yharon1Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Yharon1");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Yharon>()) && !BossRushEvent.BossRushActive;
    }
}
