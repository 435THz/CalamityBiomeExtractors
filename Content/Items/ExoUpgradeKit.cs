using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.Items.Materials;
using CalamityMod.Rarities;
using CalamityMod.Tiles.Furniture.CraftingStations;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class ExoUpgradeKit : ExtractorUpgradeKit
    {
        protected override int Tier => CalamityExtractionTiers.EXO;
        protected override int ResultTile => ModContent.TileType<ExoExtractorTile>();

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.RarityType<DarkOrange>();
            Item.value = Item.buyPrice(gold: 25); // sell at 5
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<ExoPrism>(), 5)
                .AddIngredient(ModContent.GetInstance<VoltageRegulationSystem>())
                .AddIngredient(ModContent.GetInstance<LongRangedSensorArray>())
                .AddIngredient(ModContent.GetInstance<AuricQuantumCoolingCell>())
                .AddTile(ModContent.TileType<DraedonsForge>())
                .Register();
        }
    }
}
