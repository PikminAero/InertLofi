using CalamityMod.Events;
using CalamityMod.NPCs.SlimeGod;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class SlimeGodScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/SlimeGod");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<SlimeGodCore>()) || NPC.AnyNPCs(ModContent.NPCType<EbonianPaladin>())
            || NPC.AnyNPCs(ModContent.NPCType<CrimulanPaladin>())
            && !BossRushEvent.BossRushActive;
    }
}
