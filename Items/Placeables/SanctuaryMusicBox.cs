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
    public class SanctuaryMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<SanctuaryMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<SeaPrism>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
