﻿using BiomeExtractorsMod.Content.TileEntities;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using Terraria.ModLoader;
using static BiomeExtractorsMod.Common.Systems.BiomeExtractionSystem;

namespace CalamityBiomeExtractors.Content.TileEntities
{
    internal class ExoExtractorEnt : BiomeExtractorEnt
    {
        protected override int TileType => ModContent.TileType<ExoExtractorTile>();
        protected override ExtractionTier ExtractionTier => Instance.GetTier(CalamityExtractionTiers.EXO, true);
    }
}