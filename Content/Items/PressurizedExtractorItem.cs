using System;
using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Content.Tiles;
using Terraria;
using Terraria.Enums;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class PressurizedExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<PressurizedExtractorTile>();

        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => throw new NotImplementedException();

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.SetShopValues(ItemRarityColor.LightRed4, Item.buyPrice(gold: 30)); // sell at 6
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SulphuricExtractorItem>())
                .AddIngredient(ModContent.ItemType<PressurizedUpgradeKit>())
                .Register();
        }
    }
}
