using System;
using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Content.Tiles;
using Terraria;
using Terraria.Enums;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class ThermoresistantExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<ThermoresistantExtractorTile>();

        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => throw new NotImplementedException();

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.SetShopValues(ItemRarityColor.LightRed4, Item.buyPrice(gold: 40)); // sell at 8
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<PressurizedExtractorItem>())
                .AddIngredient(ModContent.ItemType<ThermoresistantUpgradeKit>())
                .Register();
        }
    }
}
