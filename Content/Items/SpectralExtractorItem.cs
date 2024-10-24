using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Rarities;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class SpectralExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<SpectralExtractorTile>();
        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => ModContent.GetInstance<SpectralUpgradeKit>();

        public override void SetDefaults()
        {
            base.SetDefaults();
            BiomeExtractionSystem.Instance.AddTier(CalamityExtractionTiers.SPECTRAL, $"{CalamityBiomeExtractors.LocArticles}.Spectral", CalamityBiomeExtractors.LocItemsExtractorName("Spectral"), delegate { return Configs.Instance.SpectralExtractorRate; }, delegate { return Configs.Instance.SpectralExtractorChance; }, delegate { return Mod.Assets.Request<Texture2D>("Content/MapIcons/SpectralExtractorIcon"); });
            Item.rare = ModContent.RarityType<PureGreen>();
            Item.value = Item.buyPrice(gold: 60); // sell at 12
        }
    }
}
