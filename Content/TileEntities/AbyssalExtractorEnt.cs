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
    internal class AbyssalExtractorEnt : BiomeExtractorEnt
    {
        //"", "Content/MapIcons/BiomeExtractorIconSteampunk", 0, 1
        private readonly ExtractorIconOverride _iconOverride = ExtractorIconOverride.Invalid;
        protected override ExtractorIconOverride IconOverride => _iconOverride;
        protected override string LocalName => Language.GetTextValue(CalamityBiomeExtractors.LocItemsExtractorName("Abyssal"));
        protected override int ExtractionRate => Configs.Instance.AbyssalExtractorRate;
        protected override int ExtractionChance => Configs.Instance.AbyssalExtractorChance;
        protected override int TileType => ModContent.TileType<AbyssalExtractorTile>();

        protected override ExtractionTier ExtractionTier => Instance.GetTier(CalamityExtractionTiers.SPECTRAL, true);

        public override void Update()
        {
            Point point = Position.ToPoint() + new Point(1, 1);
            if (BiomeChecker.IsInAbyssArea(point) && BiomeChecker.IsSubmerged(point))
                Active = false;

            base.Update();
        }
    }
}
