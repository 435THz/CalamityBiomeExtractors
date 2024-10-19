using BiomeExtractorsMod.Content.TileEntities;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using Terraria.ModLoader;
using static BiomeExtractorsMod.Common.Systems.BiomeExtractionSystem;

namespace CalamityBiomeExtractors.Content.TileEntities
{
    internal class AuricExtractorEnt : BiomeExtractorEnt
    {
        protected override int TileType => ModContent.TileType<AuricExtractorTile>();
        protected override ExtractionTier ExtractionTier => Instance.GetTier(CalamityExtractionTiers.AURIC, true);
    }
}
