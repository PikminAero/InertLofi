﻿using InertLofi.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Items.Placeables
{
    public class SBTCMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<SBTCMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient(ItemID.LunarBar, 5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
