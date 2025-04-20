using CalamityMod.Events;
using CalamityMod.NPCs.Polterghast;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class PolterghastScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Polterghast");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Polterghast>()) && !BossRushEvent.BossRushActive;
    }
}
