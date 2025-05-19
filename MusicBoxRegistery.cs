using InertLofi.Items.Placeables;
using InertLofi.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace InertLofi
{
    public class MusicBoxRegistery : ModSystem
    {
        private static void AddMusicBox(string musicFile, int itemID, int tileID)
        {
            int musicID = MusicLoader.GetMusicSlot(InertLofiMod.Instance, musicFile);
            MusicLoader.AddMusicBox(InertLofiMod.Instance, musicID, itemID, tileID);
        }

        public override void PostSetupContent()
        {
            // Title
            AddMusicBox("Assets/Music/CalamityTitle", ModContent.ItemType<TOACWMusicBox>(), ModContent.TileType<TOACWMusicBoxTile>());
            // Boss Music
            AddMusicBox("Assets/Anahita", ModContent.ItemType<FLMusicBox>(), ModContent.TileType<FLMusicBoxTile>());
            AddMusicBox("Assets/AnahitasLure", ModContent.ItemType<LureMusicBox>(), ModContent.TileType<LureMusicBoxTile>());
            AddMusicBox("Assets/AquaticScourge", ModContent.ItemType<OOTSSMusicBox>(), ModContent.TileType<OOTSSMusicBoxTile>());
            AddMusicBox("Assets/Music/AstrumAureus", ModContent.ItemType<ISMusicBox>(), ModContent.TileType<ISMusicBoxTile>());
            AddMusicBox("Assets/Music/AstrumDeus", ModContent.ItemType<POTCMusicBox>(), ModContent.TileType<POTCMusicBoxTile>());
            AddMusicBox("Assets/Music/BrimstoneElemental", ModContent.ItemType<LAMusicBox>(), ModContent.TileType<LAMusicBoxTile>());
            AddMusicBox("Assets/Music/CalamitasClone", ModContent.ItemType<RUCMusicBox>(), ModContent.TileType<RUCMusicBoxTile>());
            AddMusicBox("Assets/Music/CalamitasPhase1", ModContent.ItemType<SBC1MusicBox>(), ModContent.TileType<SBC1MusicBoxTile>());
            AddMusicBox("Assets/Music/CalamitasPhase2", ModContent.ItemType<SBC2MusicBox>(), ModContent.TileType<SBC2MusicBoxTile>());
            AddMusicBox("Assets/Music/CalamitasPhase3", ModContent.ItemType<SBC3MusicBox>(), ModContent.TileType<SBC3MusicBoxTile>());
            AddMusicBox("Assets/Music/CeaselessVoid", ModContent.ItemType<Servants2MusicBox>(), ModContent.TileType<Servants2MusicBoxTile>());
            AddMusicBox("Assets/Music/Crabulon", ModContent.ItemType<CrabulonMusicBox>(), ModContent.TileType<CrabulonMusicBoxTile>());
            AddMusicBox("Assets/Music/Cryogen", ModContent.ItemType<ARMusicBox>(), ModContent.TileType<ARMusicBoxTile>());
            AddMusicBox("Assets/Music/DesertScourge", ModContent.ItemType<GOTFSMusicBox>(), ModContent.TileType<GOTFSMusicBoxTile>());
            AddMusicBox("Assets/Music/DevourerofGodsPhase1", ModContent.ItemType<SOTUMusicBox>(), ModContent.TileType<SOTUMusicBoxTile>());
            AddMusicBox("Assets/Music/DevourerofGodsPhase2", ModContent.ItemType<UCMusicBox>(), ModContent.TileType<UCMusicBoxTile>());
            AddMusicBox("Assets/Music/Dragonfolly", ModContent.ItemType<MurderswarmMusicBox>(), ModContent.TileType<MurderswarmMusicBoxTile>());
            AddMusicBox("Assets/Music/HiveMind", ModContent.ItemType<TFMMusicBox>(), ModContent.TileType<TFMMusicBoxTile>());
            AddMusicBox("Assets/Music/Leviathan", ModContent.ItemType<SWMusicBox>(), ModContent.TileType<SWMusicBoxTile>());
            AddMusicBox("Assets/Music/OldDuke", ModContent.ItemType<TWMusicBox>(), ModContent.TileType<TWMusicBoxTile>());
            AddMusicBox("Assets/Music/Perforators", ModContent.ItemType<BCMusicBox>(), ModContent.TileType<BCMusicBoxTile>());
            AddMusicBox("Assets/Music/PlaguebringerGoliath", ModContent.ItemType<FOTBMusicBox>(), ModContent.TileType<FOTBMusicBoxTile>());
            AddMusicBox("Assets/Music/Polterghast", ModContent.ItemType<FAMusicBox>(), ModContent.TileType<FAMusicBoxTile>());
            AddMusicBox("Assets/Music/PrimordialWyrm", ModContent.ItemType<TOTOFMusicBox>(), ModContent.TileType<TOTOFMusicBoxTile>());
            AddMusicBox("Assets/Music/ProfanedGuardians", ModContent.ItemType<UAMusicBox>(), ModContent.TileType<UAMusicBoxTile>());
            AddMusicBox("Assets/Music/Providence", ModContent.ItemType<UIMusicBox>(), ModContent.TileType<UIMusicBoxTile>());
            AddMusicBox("Assets/Music/Ravager", ModContent.ItemType<OFMusicBox>(), ModContent.TileType<OFMusicBoxTile>());
            AddMusicBox("Assets/Music/Signus", ModContent.ItemType<Servants3MusicBox>(), ModContent.TileType<Servants3MusicBoxTile>());
            AddMusicBox("Assets/Music/SlimeGod", ModContent.ItemType<RTSMusicBox>(), ModContent.TileType<RTSMusicBoxTile>());
            AddMusicBox("Assets/Music/StormWeaver", ModContent.ItemType<Servants1MusicBox>(), ModContent.TileType<Servants1MusicBoxTile>());
            AddMusicBox("Assets/Music/YharonPhase1", ModContent.ItemType<ICMusicBox>(), ModContent.TileType<ICMusicBoxTile>());
            AddMusicBox("Assets/Music/YharonPhase2", ModContent.ItemType<ROTJDMusicBox>(), ModContent.TileType<ROTJDMusicBoxTile>());

            // Biome music
            AddMusicBox("Assets/AbyssLayer1", ModContent.ItemType<HesitationMusicBox>(), ModContent.TileType<HesitationMusicBoxTile>());
            AddMusicBox("Assets/AbyssLayer2", ModContent.ItemType<HPMusicBox>(), ModContent.TileType<HPMusicBoxTile>());
            AddMusicBox("Assets/AbyssLayer4", ModContent.ItemType<VoidMusicBox>(), ModContent.TileType<VoidMusicBoxTile>());
            AddMusicBox("Assets/AstralInfection", ModContent.ItemType<HSAMusicBox>(), ModContent.TileType<HSAMusicBoxTile>());
            AddMusicBox("Assets/AstralInfectionUnderground", ModContent.ItemType<TWTAMusicBox>(), ModContent.TileType<TWTAMusicBoxTile>());
            AddMusicBox("Assets/Music/BioLab", ModContent.ItemType<ESMusicBox>(), ModContent.TileType<ESMusicBoxTile>());
            AddMusicBox("Assets/Music/BrimstoneCrags", ModContent.ItemType<TSBHMusicBox>(), ModContent.TileType<TSBHFMusicBoxTile>());
            AddMusicBox("Assets/Music/Planetoids", ModContent.ItemType<BOTMMusicBox>(), ModContent.TileType<BOTMMusicBoxTile>());
            AddMusicBox("Assets/Music/SulphurousSeaDay", ModContent.ItemType<WastelandMusicBox>(), ModContent.TileType<WastelandMusicBoxTile>());
            AddMusicBox("Assets/Music/SulphurousSeaNight", ModContent.ItemType<CausticTidesMusicBox>(), ModContent.TileType<CausticTidesMusicBoxTile>());
            AddMusicBox("Assets/Music/SunkenSea", ModContent.ItemType<SanctuaryMusicBox>(), ModContent.TileType<SanctuaryMusicBoxTile>());

            // Event music (Lantern Night and Interludes included)
            AddMusicBox("Assets/Music/CalamitasDefeat", ModContent.ItemType<SBC4MusicBox>(), ModContent.TileType<SBC4MusicBoxTile>());
            AddMusicBox("Assets/Music/DevourerofGodsEulogy", ModContent.ItemType<EFTEMusicBox>(), ModContent.TileType<EFTEMusicBoxTile>());
            AddMusicBox("Assets/Music/Interlude1", ModContent.ItemType<SBTSMusicBox>(), ModContent.TileType<SBTSMusicBoxTile>());
            AddMusicBox("Assets/Music/Interlude2", ModContent.ItemType<SBTCMusicBox>(), ModContent.TileType<SBTCMusicBoxTile>());
            AddMusicBox("Assets/Music/Interlude3", ModContent.ItemType<CBTCMusicBox>(), ModContent.TileType<CBTCMusicBoxTile>());
            AddMusicBox("Assets/Music/LanternNight", ModContent.ItemType<SerenityMusicBox>(), ModContent.TileType<SerenityMusicBoxTile>());
        }
    }
}
