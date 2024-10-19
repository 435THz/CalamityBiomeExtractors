using BiomeExtractorsMod.Content.Items;
using CalamityBiomeExtractors.Common;
using CalamityBiomeExtractors.Content.Tiles;
using CalamityMod.Items.Materials;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityBiomeExtractors.Content.Items
{
    internal class SpectralUpgradeKit : ExtractorUpgradeKit
    {
        protected override int Tier => CalamityExtractionTiers.SPECTRAL;

        protected override int ResultTile => ModContent.TileType<PressurizedExtractorTile>();

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.RarityType<PureGreen>();
            Item.value = Item.buyPrice(gold: 10); // sell at 2
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BloodstoneCore>(), 5)
                .AddIngredient(ModContent.ItemType<ReaperTooth>(), 12)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
