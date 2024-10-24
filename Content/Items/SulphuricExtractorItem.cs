using System;
using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Content.Tiles;
using Terraria;
using Terraria.Enums;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class SulphuricExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<SulphuricExtractorTile>();

        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => throw new NotImplementedException();

        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 5;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.SetShopValues(ItemRarityColor.Orange3, Item.buyPrice(gold: 22)); // sell at 4.4
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(ModContent.GetInstance<Recipes>().demonicExtractorGroupName)
                .AddIngredient(ModContent.ItemType<SulphuricUpgradeKit>())
                .Register();
        }
    }
}
