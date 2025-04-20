using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class SulphurSeaScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/SulphurSea");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<SulphurousSeaBiome>();
    }
}
