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
    internal class ThermoresistantExtractorEnt : BiomeExtractorEnt
    {
        private readonly ExtractorIconOverride _iconOverride = new($"{CalamityBiomeExtractors.LocItemsExtractorName("Thermoresistant")}", delegate { return CalamityBiomeExtractors.Instance.Assets.Request<Texture2D>("Content/MapIcons/ThermoresistantExtractorIcon"); }, 0, 1);
        protected override ExtractorIconOverride IconOverride => _iconOverride;
        protected override string LocalName => Language.GetTextValue(CalamityBiomeExtractors.LocItemsExtractorName("Thermoresistant"));
        protected override int ExtractionRate => Configs.Instance.ThermoresistantExtractorRate;
        protected override int ExtractionChance => Configs.Instance.ThermoresistantExtractorChance;
        protected override int TileType => ModContent.TileType<ThermoresistantExtractorTile>();

        protected override ExtractionTier ExtractionTier => Instance.GetTier((int)EnumTiers.CYBER, true);

        public override void Update()
        {
            Point point = Position.ToPoint() + new Point(1, 1);
            if (!BiomeChecker.IsInAbyssArea(point) || !BiomeChecker.IsSubmerged(point))
                Active = false;

            base.Update();
        }
    }
}
