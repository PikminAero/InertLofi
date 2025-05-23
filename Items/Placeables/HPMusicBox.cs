﻿using CalamityMod.Items.Placeables;
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
    public class HPMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<HPMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<AbyssGravel>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
