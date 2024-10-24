using BiomeExtractorsMod.Content.TileEntities;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static BiomeExtractorsMod.Common.Systems.BiomeExtractionSystem;

namespace CalamityBiomeExtractors.Content.TileEntities
{
    internal class AbyssalExtractorEnt : BiomeExtractorEnt
    {
        private readonly ExtractorIconOverride _iconOverride = new($"{CalamityBiomeExtractors.LocItemsExtractorName("Abyssal")}", delegate { return CalamityBiomeExtractors.Instance.Assets.Request<Texture2D>("Content/MapIcons/AbyssalExtractorIcon"); }, 0, 1);
        protected override ExtractorIconOverride IconOverride => _iconOverride;
        protected override string LocalName => Language.GetTextValue(CalamityBiomeExtractors.LocItemsExtractorName("Abyssal"));
        protected override int ExtractionRate => Configs.Instance.AbyssalExtractorRate;
        protected override int ExtractionChance => Configs.Instance.AbyssalExtractorChance;
        protected override int TileType => ModContent.TileType<AbyssalExtractorTile>();

        protected override ExtractionTier ExtractionTier => Instance.GetTier(CalamityExtractionTiers.SPECTRAL, true);

        public override void Update()
        {
            Point point = Position.ToPoint() + new Point(1, 1);
            if (!BiomeChecker.IsInAbyssArea(point) || !BiomeChecker.IsSubmerged(point))
                Active = false;

            base.Update();
        }
    }
}
