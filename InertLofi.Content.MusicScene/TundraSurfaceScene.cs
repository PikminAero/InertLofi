using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Scenes.MusicScenes;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class TundraSurfaceScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/TundraSurfaceScene");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.ZoneSnow
            && ModContent.GetInstance<InertLofiConfig>().ReplaceTundraSurface
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

