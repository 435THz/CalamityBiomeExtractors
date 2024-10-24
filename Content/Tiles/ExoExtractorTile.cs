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
    internal class ExoExtractorTile : BiomeExtractorTile
    {
        protected override int FrameCount => 1; //TODO

        protected override BiomeExtractorEnt TileEntity => ModContent.GetInstance<ExoExtractorEnt>();

        protected override void SetupTileData()
        {
            DustType = DustID.Silver;
            Main.tileLighted[Type] = true;
            TileObjectData.newTile.LavaDeath = false;
        }

        protected override void CreateMapEntries()
        {
            AddMapEntry(new(89, 89, 103), MapEntryName);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            bool found = TileUtils.TryGetTileEntityAs(i, j, out BiomeExtractorEnt entity);
            if (!found || !entity.Active)
            {
                r = 0.4f;
                g = 0.4f;
                b = 0.2f;
                return;
            }
            r = 1.0f;
            g = 1.0f;
            b = 0.5f;
        }

        protected override int ItemType(Tile tile)
        {
            return ModContent.ItemType<ExoExtractorItem>();
        }
    }
}
