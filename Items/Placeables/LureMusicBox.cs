using CalamityMod.Items.Accessories;
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
    public class LureMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<LureMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<LeviathanAmbergris>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
