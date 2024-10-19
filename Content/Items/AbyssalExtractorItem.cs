using System;
using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class AbyssalExtractorItem : BiomeExtractorItem
    {
        protected override int TileId => ModContent.TileType<AbyssalExtractorTile>();

        protected override ExtractorUpgradeKit UpgradeItemToCraftThis => throw new NotImplementedException();

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.RarityType<PureGreen>();
            Item.value = Item.buyPrice(gold: 60); // sell at 12
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<ThermoresistantExtractorItem>())
                .AddIngredient(ModContent.ItemType<AbyssalUpgradeKit>())
                .Register();
        }
    }
}
