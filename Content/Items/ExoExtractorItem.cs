﻿using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class ExoExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<ExoExtractorTile>();
        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => ModContent.GetInstance<ExoUpgradeKit>();

        public override void SetDefaults()
        {
            base.SetDefaults();
            BiomeExtractionSystem.Instance.AddTier(CalamityExtractionTiers.EXO, $"{CalamityBiomeExtractors.LocArticles}.Exo", CalamityBiomeExtractors.LocItemsExtractorName("Exo"), delegate { return Configs.Instance.ExoExtractorRate; }, delegate { return Configs.Instance.ExoExtractorChance; }, "Content/MapIcons/ExoExtractorIcon");
            Item.rare = ModContent.RarityType<DarkOrange>();
            Item.value = Item.buyPrice(platinum: 1); // sell at 20
        }
    }
}