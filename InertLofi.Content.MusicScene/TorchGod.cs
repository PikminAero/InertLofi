using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
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
        int torchGodNPC = NPC.FindFirstNPC(NPCID.TorchGod);
        if (torchGodNPC != -1)
        {
            float distToPlayer = Main.npc[torchGodNPC].Distance(player.Center);
            return (player.happyFunTorchTime || distToPlayer <= 525f * 16f) // magic number from VCMM
                && ModContent.GetInstance<InertLofiConfig>().ReplaceTorchGod
                && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
        else
        {
            return false;
        }
    }
}

