using CalamityMod.Items.TreasureBags.MiscGrabBags;
using InertLofi.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Items.Placeables
{
    public class OFMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<OFMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<FleshyGeode>(1).AddTile(TileID.WorkBenches).Register();
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<NecromanticGeode>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
