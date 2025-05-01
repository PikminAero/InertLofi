using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class SulphurSeaDayScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/SulphurousSeaDay");

    public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<SulphurousSeaBiome>() && !BossRushEvent.BossRushActive && Main.IsItDay()
            && ModContent.GetInstance<InertLofiConfig>().ReplaceSulphurSeaDay
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
