using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Abyss1Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AbyssLayer1");

    public override SceneEffectPriority Priority => SceneEffectPriority.Event;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<AbyssLayer1Biome>();
    }
}
