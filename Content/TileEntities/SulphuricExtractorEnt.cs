using BiomeExtractorsMod.Content.TileEntities;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using static BiomeExtractorsMod.Common.Systems.BiomeExtractionSystem;

namespace CalamityBiomeExtractors.Content.TileEntities
{
    internal class SulphuricExtractorEnt : BiomeExtractorEnt
    {
        //"", "Content/MapIcons/BiomeExtractorIconSteampunk", 0, 1
        private readonly ExtractorIconOverride _iconOverride = ExtractorIconOverride.Invalid;
        protected override ExtractorIconOverride IconOverride => _iconOverride;
        protected override string LocalName => Language.GetTextValue(CalamityBiomeExtractors.LocItemsExtractorName("Sulphuric"));
        protected override int ExtractionRate => Configs.Instance.SulphuricExtractorRate * (BiomeChecker.IsSubmerged((Position + Point16.NegativeOne).ToPoint()) ? 100 : Configs.Instance.SulphuricExtractorDryEfficiency) / 100;
        protected override int ExtractionChance => Configs.Instance.SulphuricExtractorChance;
        protected override int TileType => ModContent.TileType<SulphuricExtractorTile>();

        protected override ExtractionTier ExtractionTier => Instance.GetTier((int)EnumTiers.DEMONIC, true);
    }
}
