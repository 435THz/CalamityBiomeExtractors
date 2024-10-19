using BiomeExtractorsMod.Content.TileEntities;
using BiomeExtractorsMod.Content.Tiles;
using CalamityBiomeExtractors.Content.Items;
using CalamityBiomeExtractors.Content.TileEntities;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CalamityBiomeExtractors.Content.Tiles
{
    internal class SpectralExtractorTile : BiomeExtractorTile
    {
        protected override int FrameCount => throw new NotImplementedException(); //todo

        protected override BiomeExtractorEnt TileEntity => ModContent.GetInstance<SpectralExtractorEnt>();

        protected override void SetupTileData()
        {
            //todo dust type
            //todo lighting
            TileObjectData.newTile.LavaDeath = false;
        }

        protected override void CreateMapEntries()
        {
            AddMapEntry(new(0, 0, 0), MapEntryName); //todo choose color
        }

        protected override int ItemType(Tile tile)
        {
            return ModContent.ItemType<SpectralExtractorItem>();
        }
    }
}
