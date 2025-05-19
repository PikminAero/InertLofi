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
    public class TWMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<TWMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<OldDukeScales>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
