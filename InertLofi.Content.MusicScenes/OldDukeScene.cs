using CalamityMod.Events;
using CalamityMod.NPCs.OldDuke;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class OldDukeScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Polterghast");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<OldDuke>()) && !BossRushEvent.BossRushActive;
    }
}
