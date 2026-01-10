using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Scenes.MusicScenes;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class TorchGod : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/TownDay");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(NPCID.TorchGod) // Unsure if this works... wiki says this ID is "dummy"
            && ModContent.GetInstance<InertLofiConfig>().ReplaceTorchGod
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

