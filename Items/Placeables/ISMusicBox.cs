using CalamityMod.Items.Potions;
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
    public class ISMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<ISMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<AureusCell>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
