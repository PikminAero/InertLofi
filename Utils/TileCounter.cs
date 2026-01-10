using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Utils
{
    public class TileCounter : ModSystem
    {
        public static int DirtStoneMud = 0;

        public static int MeteoriteOre = 0;

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            DirtStoneMud = tileCounts[TileID.Dirt] + tileCounts[TileID.Stone] + tileCounts[TileID.Mud];
            MeteoriteOre = tileCounts[TileID.Meteorite];
        }
    }
}
