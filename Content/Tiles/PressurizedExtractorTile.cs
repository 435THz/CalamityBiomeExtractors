﻿using BiomeExtractorsMod.Content.TileEntities;
using BiomeExtractorsMod.Content.Tiles;
using CalamityBiomeExtractors.Content.Items;
using CalamityBiomeExtractors.Content.TileEntities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CalamityBiomeExtractors.Content.Tiles
{
    internal class PressurizedExtractorTile : BiomeExtractorTile
    {
        protected override int FrameCount => 1; //TODO

        protected override BiomeExtractorEnt TileEntity => ModContent.GetInstance<PressurizedExtractorEnt>();

        protected override void SetupTileData()
        {
            DustType = DustID.GrassBlades;

            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.LavaDeath = true;
        }

        protected override void CreateMapEntries()
        {
            AddMapEntry(new(43, 68, 17), MapEntryName);
        }

        protected override int ItemType(Tile tile)
        {
            return ModContent.ItemType<PressurizedExtractorItem>();
        }
    }
}
