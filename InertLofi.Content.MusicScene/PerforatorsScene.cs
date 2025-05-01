using CalamityMod.Events;
using CalamityMod.NPCs.Perforator;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class PerforatorsScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Perforators");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<PerforatorHive>()) || NPC.AnyNPCs(ModContent.NPCType<PerforatorHeadSmall>()) 
            || NPC.AnyNPCs(ModContent.NPCType<PerforatorHeadMedium>()) || NPC.AnyNPCs(ModContent.NPCType<PerforatorHeadLarge>())
            && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplacePerforators
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
