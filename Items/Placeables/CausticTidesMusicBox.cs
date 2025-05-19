using CalamityMod.Items.Placeables;
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
    public class CausticTidesMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<CausticTidesMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<Acidwood>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
