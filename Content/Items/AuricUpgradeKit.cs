using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Items.Materials;
using CalamityMod.Rarities;
using CalamityMod.Tiles.Furniture.CraftingStations;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class AuricUpgradeKit : ExtractorUpgradeKit
    {
        protected override int Tier => CalamityExtractionTiers.AURIC;

        protected override int ResultTile => ModContent.TileType<AuricExtractorTile>();

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.RarityType<Violet>();
            Item.value = Item.buyPrice(gold: 15); // sell at 2
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<AuricBar>(), 5)
                .AddIngredient(ModContent.ItemType<AscendantSpiritEssence>(), 10)
                .AddIngredient(ModContent.ItemType<GalacticaSingularity>(), 2)
                .AddTile(ModContent.TileType<CosmicAnvil>())
                .Register();
        }
    }
}
