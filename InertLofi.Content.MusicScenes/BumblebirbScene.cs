using CalamityMod.Events;
using CalamityMod.NPCs.Bumblebirb;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class BumblebirbScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Bumblebirb");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<Bumblefuck>()) && !BossRushEvent.BossRushActive;
    }
}
