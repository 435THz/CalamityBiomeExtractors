using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.Items;
using BiomeExtractorsMod.Content.TileEntities;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class AuricExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<SpectralExtractorTile>();
        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => ModContent.GetInstance<SpectralUpgradeKit>();

        public override void SetDefaults()
        {
            base.SetDefaults();
            BiomeExtractionSystem.Instance.AddTier(CalamityExtractionTiers.AURIC, $"{CalamityBiomeExtractors.LocArticles}.Auric", CalamityBiomeExtractors.LocItemsExtractorName("Auric"), delegate { return Configs.Instance.AuricExtractorRate; }, delegate { return Configs.Instance.AuricExtractorChance; }, "Content/MapIcons/AuricExtractorIcon");
            Item.rare = ModContent.RarityType<Violet>();
            Item.value = Item.buyPrice(gold: 75); // sell at 15
        }
    }
}
