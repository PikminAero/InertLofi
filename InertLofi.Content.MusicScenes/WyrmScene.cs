using CalamityMod.Events;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.PrimordialWyrm;
using CalamityMod.NPCs.Yharon;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class WyrmScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Yharon1");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<EidolonWyrmHead>()) 
            || NPC.AnyNPCs(ModContent.NPCType<ColossalSquid>())
            || NPC.AnyNPCs(ModContent.NPCType<ReaperShark>())
            || NPC.AnyNPCs(ModContent.NPCType<PrimordialWyrmHead>())
            && !BossRushEvent.BossRushActive;
    }
}
