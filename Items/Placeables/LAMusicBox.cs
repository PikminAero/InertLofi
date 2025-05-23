﻿using CalamityMod.Items.Accessories;
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
    public class LAMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<LAMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<FlameLickedShell>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
