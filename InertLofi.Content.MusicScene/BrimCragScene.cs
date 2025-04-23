using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Scenes.MusicScenes;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class BrimCragScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/BrimstoneCrags");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<BrimstoneCragsBiome>();
    }
}
