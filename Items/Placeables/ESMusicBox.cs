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
    public class ESMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<ESMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<DubiousPlating>(5)
                .AddIngredient<MysteriousCircuitry>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
