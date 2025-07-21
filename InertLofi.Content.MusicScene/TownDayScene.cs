using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Scenes.MusicScenes;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class TownDayScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/TownDay");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.townNPCs > 2f
            && ModContent.GetInstance<InertLofiConfig>().ReplaceTownDay
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

