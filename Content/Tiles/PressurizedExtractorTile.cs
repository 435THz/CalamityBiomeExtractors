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
    internal class PressurizedExtractorTile : BiomeExtractorTile
    {
        protected override int FrameCount => throw new NotImplementedException(); //todo

        protected override BiomeExtractorEnt TileEntity => ModContent.GetInstance<PressurizedExtractorEnt>();

        protected override void SetupTileData()
        {
            //todo dust type

            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.LavaDeath = true;
        }

        protected override void CreateMapEntries()
        {
            AddMapEntry(new(0, 0, 0), MapEntryName); //todo choose color
        }

        protected override int ItemType(Tile tile)
        {
            return ModContent.ItemType<PressurizedExtractorItem>();
        }
    }
}
