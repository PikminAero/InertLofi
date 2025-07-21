using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Abyss3Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AbyssLayer3");

    public override SceneEffectPriority Priority => SceneEffectPriority.Event;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<AbyssLayer3Biome>() && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceAbyss3
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}

