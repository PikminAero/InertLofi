using CalamityMod.BiomeManagers;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class AstralSurfaceScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AstralSurface");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<AstralInfectionBiome>();
    }
}
