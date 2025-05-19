using CalamityMod.Items.Materials;
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
    public class RTSMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<RTSMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<PurifiedGel>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
