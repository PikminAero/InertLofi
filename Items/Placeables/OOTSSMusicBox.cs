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
    public class OOTSSMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<OOTSSMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<AquaticEmblem>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
