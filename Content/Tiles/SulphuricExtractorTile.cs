using BiomeExtractorsMod.Content.TileEntities;
using BiomeExtractorsMod.Content.Tiles;
using CalamityBiomeExtractors.Content.Items;
using CalamityBiomeExtractors.Content.TileEntities;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CalamityBiomeExtractors.Content.Tiles
{
    internal class SulphuricExtractorTile : BiomeExtractorTile
    {
        protected override int FrameCount => 1; //TODO

        protected override BiomeExtractorEnt TileEntity => ModContent.GetInstance<SulphuricExtractorEnt>();

        protected override void SetupTileData()
        {
            DustType = DustID.DemonTorch;

            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.LavaDeath = true;
        }

        protected override void CreateMapEntries()
        {
            AddMapEntry(new(144, 114, 166), MapEntryName);
        }

        protected override int ItemType(Tile tile)
        {
            return ModContent.ItemType<SulphuricExtractorItem>();
        }
    }
}
