using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using CalamityMod.Scenes.MusicScenes;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class TorchGod : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/TorchGod");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        // Pulled straight from VCMM.
        // 525f * 16f was originally named PlayerFlags.MusicTileRange and seems to be some magic number.
        // I shall not question it
        return player.happyFunTorchTime || (NPC.AnyNPCs(NPCID.TorchGod) && Main.npc[NPC.FindFirstNPC(NPCID.TorchGod)].Distance(player.Center) <= 525f * 16f)
            && !BossRushEvent.BossRushActive
            && InertLofiConfig.Instance.ReplaceTorchGod
            && InertLofiConfig.Instance.ToggleAll;
    }
}

