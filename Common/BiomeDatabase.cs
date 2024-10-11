using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.TileEntities;
using BiomeExtractorsMod.Content.Tiles;
using CalamityMod;
using CalamityMod.Items.Placeables;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Critters;
using CalamityMod.Items.Placeables.Ores;
using CalamityMod.World;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static BiomeExtractorsMod.Common.Systems.BiomeExtractionSystem;
using NavystoneTile = CalamityMod.Tiles.SunkenSea.Navystone;
using EutrophicSandTile = CalamityMod.Tiles.SunkenSea.EutrophicSand;
using SeaPrismTile = CalamityMod.Tiles.SunkenSea.SeaPrism;
using SulphurousSandTile = CalamityMod.Tiles.Abyss.SulphurousSand;
using SulphurousSandstoneTile = CalamityMod.Tiles.Abyss.SulphurousSandstone;
using HardenedSulphurousSandstoneTile = CalamityMod.Tiles.Abyss.HardenedSulphurousSandstone;
using AbyssGravelTile = CalamityMod.Tiles.Abyss.AbyssGravel;
using PyreMantleTile = CalamityMod.Tiles.Abyss.PyreMantle;
using PyreMantleMoltenTile = CalamityMod.Tiles.Abyss.PyreMantleMolten;
using VoidstoneTile = CalamityMod.Tiles.Abyss.Voidstone;
using BrimstoneSlagTile = CalamityMod.Tiles.Crags.BrimstoneSlag;
using InfernalSueviteTile = CalamityMod.Tiles.Ores.InfernalSuevite;
using AstralDirtTile = CalamityMod.Tiles.Astral.AstralDirt;
using AstralStoneTile = CalamityMod.Tiles.Astral.AstralStone;
using AstralClayTile = CalamityMod.Tiles.Astral.AstralClay;
using AstralOreTile = CalamityMod.Tiles.Ores.AstralOre;
using NovaeSlagTile = CalamityMod.Tiles.Astral.NovaeSlag;
using AstralGrassTile = CalamityMod.Tiles.Astral.AstralGrass;
using AstralIceTile = CalamityMod.Tiles.AstralSnow.AstralIce;
using AstralSandTile = CalamityMod.Tiles.AstralDesert.AstralSand;
using AstralSandstoneTile = CalamityMod.Tiles.AstralDesert.AstralSandstone;
using HardenedAstralSandTile = CalamityMod.Tiles.AstralDesert.HardenedAstralSand;
using CalamityMod.Items.SummonItems;

namespace CalamityBiomeExtractors.Common
{
    internal class BiomeDatabase : ModSystem
    {
        static BiomeExtractionSystem BES => Instance;

        #region IDs
        public static readonly string sunken_sea = "sunken_sea";
        public static readonly string sunken_sea_ds = "sunken_sea_ds";
        public static readonly string sulphur_sea = "sulphur_sea";
        public static readonly string sulphur_sea_hm = "sulphur_sea_hm";
        public static readonly string sulphur_sea_as = "sulphur_sea_as";
        public static readonly string sulphur_sea_ml = "sulphur_sea_ml";
        public static readonly string sulphur_depths = "sulphur_depths";
        public static readonly string sulphur_depths_lev = "sulphur_depths_lev";
        public static readonly string murky_waters = "murky_waters";
        public static readonly string murky_waters_lev = "murky_waters_leb";
        public static readonly string murky_waters_glm = "murky_waters_glm";
        public static readonly string thermal_vents = "thermal_vents";
        public static readonly string thermal_vents_pla = "thermal_vents_pla";
        public static readonly string thermal_vents_lev = "thermal_vents_lev";
        public static readonly string thermal_vents_glm = "thermal_vents_glm";
        public static readonly string the_void = "the_void";
        public static readonly string the_void_pla = "the_void_pla";
        public static readonly string the_void_lev = "the_void_lev";
        public static readonly string the_void_pgh = "the_void_pgh";
        public static readonly string brimstone_crag = "brimstone_crag";
        public static readonly string brimstone_crag_hm = "brimstone_crag_hm";
        public static readonly string brimstone_crag_mch = "brimstone_crag_mch";
        public static readonly string brimstone_crag_prv = "brimstone_crag_prv";
        public static readonly string astral_forest = "astral_forest";
        public static readonly string astral_ore_forest = "astral_ore_forest";
        public static readonly string astral_snow = "astral_snow";
        public static readonly string astral_ore_snow = "astral_ore_snow";
        public static readonly string astral_desert = "astral_desert";
        public static readonly string astral_ore_desert = "astral_ore_desert";
        public static readonly string ug_astral_forest = "ug_astral_forest";
        public static readonly string ug_astral_ore_forest = "ug_astral_ore_forest";
        public static readonly string ug_astral_snow = "ug_astral_snow";
        public static readonly string ug_astral_ore_snow = "ug_astral_ore_snow";
        public static readonly string ug_astral_desert = "ug_astral_desert";
        public static readonly string ug_astral_ore_desert = "ug_astral_ore_desert";

        #endregion

        #region Checks
        //BLOCK LISTS
        static readonly ushort[] sunken_sea_blocks = [(ushort)ModContent.TileType<NavystoneTile>(), (ushort)ModContent.TileType<EutrophicSandTile>(), (ushort)ModContent.TileType<SeaPrismTile>()];
        static readonly ushort[] sulphur_sea_blocks = [(ushort)ModContent.TileType<SulphurousSandTile>(), (ushort)ModContent.TileType<SulphurousSandstoneTile>(), (ushort)ModContent.TileType<HardenedSulphurousSandstoneTile>()];
        static readonly ushort[] abyss_gravel = [(ushort)ModContent.TileType<AbyssGravelTile>()];
        static readonly ushort[] thermal_blocks = [(ushort)ModContent.TileType<PyreMantleTile>(), (ushort)ModContent.TileType<PyreMantleMoltenTile>()];
        static readonly ushort[] voidstone = [(ushort)ModContent.TileType<VoidstoneTile>()];
        static readonly ushort[] brimstone_blocks = [(ushort)ModContent.TileType<BrimstoneSlagTile>(), (ushort)ModContent.TileType<InfernalSueviteTile>()];
        static readonly ushort[] astral_forest_blocks = [(ushort)ModContent.TileType<AstralDirtTile>(), (ushort)ModContent.TileType<AstralStoneTile>(), (ushort)ModContent.TileType<AstralOreTile>(), (ushort)ModContent.TileType<AstralClayTile>(), (ushort)ModContent.TileType<NovaeSlagTile>(), (ushort)ModContent.TileType<AstralGrassTile>()];
        static readonly ushort[] astral_snow_blocks = [(ushort)ModContent.TileType<AstralIceTile>()];
        static readonly ushort[] astral_desert_blocks = [(ushort)ModContent.TileType<AstralSandTile>(), (ushort)ModContent.TileType<AstralSandstoneTile>(), (ushort)ModContent.TileType<HardenedAstralSandTile>()];

        //COMPLEX
        static readonly Predicate<ScanData> in_sulphur_sea = scan => abyss_side.Invoke(scan) || sulphur_sea300.Invoke(scan);

        //POSITION
        static readonly Predicate<ScanData> belowSurfaceLayer = scan => scan.Y > Main.worldSurface + 1;
        static readonly Predicate<ScanData> cavernLayer = scan => scan.Y > Main.rockLayer + 1;
        static readonly Predicate<ScanData> underworldLayer = scan => scan.Y > Main.maxTilesY - 200;
        static readonly Predicate<ScanData> abyss_side = scan =>
        {
            if (Abyss.AtLeftSideOfWorld)
                { if (scan.X < 435) return true; }
            else
                { if (scan.X > Main.maxTilesX - 435) return true; }
            return false;
        };

        //PROGRESSION
        static readonly Predicate<ScanData> post_scourge = scan => CalamityConditions.DownedDesertScourge.IsMet();
        static readonly Predicate<ScanData> post_scourge2 = scan => CalamityConditions.DownedAquaticScourge.IsMet();
        static readonly Predicate<ScanData> hardmodeOnly = scan => Main.hardMode;
        static readonly Predicate<ScanData> post_plantera= scan => Condition.DownedPlantera.IsMet();
        static readonly Predicate<ScanData> post_leviathan = scan => CalamityConditions.DownedLeviathan.IsMet();
        static readonly Predicate<ScanData> post_golem = scan => Condition.DownedGolem.IsMet();
        static readonly Predicate<ScanData> post_deus = scan => CalamityConditions.DownedAstrumDeus.IsMet();
        static readonly Predicate<ScanData> post_moon_lord = scan => Condition.DownedMoonLord.IsMet();
        static readonly Predicate<ScanData> post_providence = scan => CalamityConditions.DownedProvidence.IsMet();
        static readonly Predicate<ScanData> post_polterghast = scan => CalamityConditions.DownedPolterghast.IsMet();

        //TIERS
        static readonly Predicate<ScanData> demonic = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.DEMONIC);
        static readonly Predicate<ScanData> infernal = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.INFERNAL);
        static readonly Predicate<ScanData> steampunk = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.STEAMPUNK);
        static readonly Predicate<ScanData> cyber = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.CYBER);
        static readonly Predicate<ScanData> lunar = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.LUNAR);
        static readonly Predicate<ScanData> ethereal = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL);
        static readonly Predicate<ScanData> spectral = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL); //TODO
        static readonly Predicate<ScanData> cosmic = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL); //TODO
        static readonly Predicate<ScanData> miraculous = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL); //TODO

        //BLOCKS
        static readonly Predicate<ScanData> sunken_sea150 = scan => scan.Tiles(sunken_sea_blocks) >= 150;
        static readonly Predicate<ScanData> sulphur_sea300 = scan => scan.Tiles(sulphur_sea_blocks) >= 300;
        static readonly Predicate<ScanData> abyss_gravel300 = scan => scan.Tiles(abyss_gravel) >= 300;
        static readonly Predicate<ScanData> thermal_blocks300 = scan => scan.Tiles(thermal_blocks) >= 300;
        static readonly Predicate<ScanData> voidstone300 = scan => scan.Tiles(voidstone) >= 300;
        static readonly Predicate<ScanData> brimstone100 = scan => scan.Tiles(brimstone_blocks) >= 100;
        static readonly Predicate<ScanData> astral_forest950 = scan => scan.Tiles(astral_forest_blocks) >= 950;
        static readonly Predicate<ScanData> astral_snow951 = scan => scan.Tiles(astral_snow_blocks) >= 951;
        static readonly Predicate<ScanData> astral_desert951 = scan => scan.Tiles(astral_desert_blocks) >= 951;

        //MACHINE(, TURN BACK NOW)
        static readonly Predicate<ScanData> sulphuric_extractor = scan => pressurized_extractor.Invoke(scan) || TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorSulphuric
        static readonly Predicate<ScanData> pressurized_extractor = scan => thermal_extractor.Invoke(scan) ||TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorPressurized, requires dungeon materials
        static readonly Predicate<ScanData> thermal_extractor = scan => abyssal_extractor.Invoke(scan) || TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorThermoresistant, requires post-golem materials
        static readonly Predicate<ScanData> abyssal_extractor = scan => TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorAbyssal, requires post-polterghast materials

        #endregion

        #region Database Setup
        private static string LocalizeAs(string suffix) => $"{CalamityBiomeExtractors.LocPoolNames}.{suffix}";
        public override void PostSetupContent()
        {
            InitializePools();
            SetRequirements();
            EditVanillaPools();
            PopulatePools();
            BES.GenerateLocalizationKeys();
        }

        private static void InitializePools()
        {
            BES.AddPool(new PoolEntry(astral_forest,     [hardmodeOnly, steampunk], astral_forest), 350);
            BES.AddPool(new PoolEntry(astral_snow,       [hardmodeOnly, steampunk], astral_snow),   350);
            BES.AddPool(new PoolEntry(astral_desert,     [hardmodeOnly, steampunk], astral_desert), 350);
            BES.AddPool(new PoolEntry(astral_ore_forest, [post_deus, lunar]), 350);
            BES.AddPool(new PoolEntry(astral_ore_snow,   [post_deus, lunar]), 350);
            BES.AddPool(new PoolEntry(astral_ore_desert, [post_deus, lunar]), 350);

            BES.AddPool(new PoolEntry(ug_astral_forest,     [hardmodeOnly, steampunk], ug_astral_forest), 1050);
            BES.AddPool(new PoolEntry(ug_astral_snow,       [hardmodeOnly, steampunk], ug_astral_snow),   1050);
            BES.AddPool(new PoolEntry(ug_astral_desert,     [hardmodeOnly, steampunk], ug_astral_desert), 1050);
            BES.AddPool(new PoolEntry(ug_astral_ore_forest, [post_deus, lunar]), 1050);
            BES.AddPool(new PoolEntry(ug_astral_ore_snow,   [post_deus, lunar]), 1050);
            BES.AddPool(new PoolEntry(ug_astral_ore_desert, [post_deus, lunar]), 1050);

            BES.AddPool(sunken_sea, 1050, LocalizeAs(sunken_sea));
            BES.AddPool(new PoolEntry(sunken_sea_ds, [post_scourge, belowSurfaceLayer]), 1050);

            BES.AddPool(sulphur_sea, 2600, (int)BiomeExtractorEnt.EnumTiers.DEMONIC, LocalizeAs(sulphur_sea));
            BES.AddPool(new PoolEntry(sulphur_sea_hm, [infernal, hardmodeOnly]),   2600);
            BES.AddPool(new PoolEntry(sulphur_sea_as, [steampunk, post_scourge2]), 2600);
            BES.AddPool(new PoolEntry(sulphur_sea_ml, [ethereal, post_moon_lord]), 2600);

            BES.AddPool(new PoolEntry(sulphur_depths,     [sulphuric_extractor], LocalizeAs(sulphur_depths)), 2601);
            BES.AddPool(new PoolEntry(sulphur_depths_lev, [sulphuric_extractor, post_leviathan]),             2601);
            BES.AddPool(new PoolEntry(murky_waters,     [pressurized_extractor], LocalizeAs(murky_waters)), 2602);
            BES.AddPool(new PoolEntry(murky_waters_lev, [pressurized_extractor, post_leviathan]),           2602);
            BES.AddPool(new PoolEntry(murky_waters_glm, [thermal_extractor]),                               2602);
            BES.AddPool(new PoolEntry(thermal_vents,     [thermal_extractor], LocalizeAs(thermal_vents)), 2603);
            BES.AddPool(new PoolEntry(thermal_vents_pla, [thermal_extractor, post_plantera]),             2603);
            BES.AddPool(new PoolEntry(thermal_vents_lev, [thermal_extractor, post_leviathan]),            2603);
            BES.AddPool(new PoolEntry(thermal_vents_glm, [thermal_extractor, post_golem]),                2603);
            BES.AddPool(new PoolEntry(the_void,     [abyssal_extractor], LocalizeAs(the_void)), 2604);
            BES.AddPool(new PoolEntry(the_void_pla, [abyssal_extractor, post_plantera]),        2604);
            BES.AddPool(new PoolEntry(the_void_lev, [abyssal_extractor, post_leviathan]),       2604);
            BES.AddPool(new PoolEntry(the_void_pgh, [abyssal_extractor, post_polterghast]),     2604);

            BES.AddPool(brimstone_crag,     4100, (int)BiomeExtractorEnt.EnumTiers.INFERNAL, LocalizeAs(brimstone_crag));
            BES.AddPool(brimstone_crag_mch, 4100, (int)BiomeExtractorEnt.EnumTiers.STEAMPUNK);
            BES.AddPool(new PoolEntry(brimstone_crag_hm,  [infernal, hardmodeOnly]), 4100);
            BES.AddPool(new PoolEntry(brimstone_crag_prv, [ethereal, post_providence]), 4100);
        }

        private static void SetRequirements()
        {
            BES.AddPoolRequirements(astral_forest,     astral_forest950);
            BES.AddPoolRequirements(astral_ore_forest, astral_forest950);
            BES.AddPoolRequirements(astral_snow,       astral_snow951);
            BES.AddPoolRequirements(astral_ore_snow,   astral_snow951);
            BES.AddPoolRequirements(astral_desert,     astral_desert951);
            BES.AddPoolRequirements(astral_ore_desert, astral_desert951);

            BES.AddPoolRequirements(ug_astral_forest,     belowSurfaceLayer, astral_forest950);
            BES.AddPoolRequirements(ug_astral_snow,       belowSurfaceLayer, astral_snow951);
            BES.AddPoolRequirements(ug_astral_desert,     belowSurfaceLayer, astral_desert951);
            BES.AddPoolRequirements(ug_astral_ore_forest, belowSurfaceLayer, astral_forest950);
            BES.AddPoolRequirements(ug_astral_ore_snow,   belowSurfaceLayer, astral_snow951);
            BES.AddPoolRequirements(ug_astral_ore_desert, belowSurfaceLayer, astral_desert951);

            BES.AddPoolRequirements(sunken_sea,    sunken_sea150);
            BES.AddPoolRequirements(sunken_sea_ds, sunken_sea150);

            BES.AddPoolRequirements(sulphur_sea,    in_sulphur_sea);
            BES.AddPoolRequirements(sulphur_sea_hm, in_sulphur_sea);
            BES.AddPoolRequirements(sulphur_sea_as, in_sulphur_sea);
            BES.AddPoolRequirements(sulphur_sea_ml, in_sulphur_sea);

            BES.AddPoolRequirements(sulphur_depths,     abyss_side, cavernLayer);
            BES.AddPoolRequirements(sulphur_depths_lev, abyss_side, cavernLayer);
            BES.AddPoolRequirements(murky_waters,       abyss_side, cavernLayer, abyss_gravel300);
            BES.AddPoolRequirements(murky_waters_lev,   abyss_side, cavernLayer, abyss_gravel300);
            BES.AddPoolRequirements(murky_waters_glm,   abyss_side, cavernLayer, abyss_gravel300);
            BES.AddPoolRequirements(thermal_vents,      abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(thermal_vents_pla,  abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(thermal_vents_lev,  abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(thermal_vents_glm,  abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(the_void,           abyss_side, cavernLayer, voidstone300);
            BES.AddPoolRequirements(the_void_pla,       abyss_side, cavernLayer, voidstone300);
            BES.AddPoolRequirements(the_void_lev,       abyss_side, cavernLayer, voidstone300);
            BES.AddPoolRequirements(the_void_pgh,       abyss_side, cavernLayer, voidstone300);

            BES.AddPoolRequirements(brimstone_crag,     underworldLayer, brimstone100);
            BES.AddPoolRequirements(brimstone_crag_hm,  underworldLayer, brimstone100);
            BES.AddPoolRequirements(brimstone_crag_mch, underworldLayer, brimstone100);
            BES.AddPoolRequirements(brimstone_crag_prv, underworldLayer, brimstone100);
        }

        private static void EditVanillaPools()
        {
            //TODO
        }

        private static void PopulatePools()
        {
            BES.AddItemInPool(astral_forest, ItemID.None, 72);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralDirt>(), 26);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralStone>(), 7);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralClay>(), 8);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralMonolith>(), 50);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<StarblightSoot>(), 36);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<TitanHeart>(), 4);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralGrassSeeds>(), 7);
            BES.AddItemInPool(astral_forest, ItemID.EnchantedNightcrawler, 1);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<TwinklerItem>(), 4);
            BES.AddItemInPool(astral_desert, ItemID.None, 31);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<AstralSand>(), 41);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<AstralMonolith>(), 25);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(astral_desert, ItemID.EnchantedNightcrawler, 2);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<TwinklerItem>(), 5);
            BES.AddItemInPool(astral_snow, ItemID.None, 50);
            BES.AddItemInPool(astral_snow, ItemID.SnowBlock, 27);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<AstralIce>(), 14);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<AstralMonolith>(), 17);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(astral_snow, ItemID.EnchantedNightcrawler, 2);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<TwinklerItem>(), 6);
            BES.AddItemInPool(astral_ore_forest, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(astral_ore_snow,   new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(astral_ore_desert, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);

            BES.AddItemInPool(ug_astral_forest, ItemID.None, 70);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<AstralDirt>(), 16);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<AstralStone>(), 8);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<NovaeSlag>(), 4);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<AstralSand>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<HardenedAstralSand>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<AstralSandstone>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<CelestialRemains>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(ug_astral_snow, ItemID.None, 69);
            BES.AddItemInPool(ug_astral_snow, ItemID.SnowBlock, 10);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<AstralIce>(), 10);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<NovaeSlag>(), 4);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(ug_astral_ore_forest, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(ug_astral_ore_snow,   new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(ug_astral_ore_desert, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);

            BES.AddItemInPool(sunken_sea, ItemID.None, 20);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<EutrophicSand>(), 11);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<Navystone>(), 7);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<SeaPrism>(), 13);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 13);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 10);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 3);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 1);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<BabyGhostBellItem>(), 3);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<SeaMinnowItem>(), 4);

            BES.AddItemInPool(sulphur_sea, ItemID.None, 90);
            BES.AddItemInPool(sulphur_sea, (short)ModContent.ItemType<SulphurousSand>(), 12);
            BES.AddItemInPool(sulphur_sea, (short)ModContent.ItemType<SulphurousSandstone>(), 6);
            BES.AddItemInPool(sulphur_sea, (short)ModContent.ItemType<HardenedSulphurousSandstone>(), 4);
            BES.AddItemInPool(sulphur_sea, ItemID.Coral, 5);
            BES.AddItemInPool(sulphur_sea, ItemID.Seashell, 4);
            BES.AddItemInPool(sulphur_sea, ItemID.Starfish, 3);
            BES.AddItemInPool(sulphur_sea, ItemID.Cactus, 20);
            BES.AddItemInPool(sulphur_sea_hm, ItemID.TurtleShell, 5);
            BES.AddItemInPool(sulphur_sea_as, (short)ModContent.ItemType<BabyFlakCrabItem>(), 6);
            BES.AddItemInPool(sulphur_sea_ml, (short)ModContent.ItemType<BloodwormItem>(), 1);

            BES.AddItemInPool(sulphur_depths, ItemID.None, 51);
            BES.AddItemInPool(sulphur_depths, (short)ModContent.ItemType<SulphurousShale>(), 18);
            BES.AddItemInPool(sulphur_depths, (short)ModContent.ItemType<BabyCannonballJellyfishItem>(), 7);
            BES.AddItemInPool(sulphur_depths_lev, (short)ModContent.ItemType<DepthCells>(), 1);

            BES.AddItemInPool(murky_waters, ItemID.None, 62);
            BES.AddItemInPool(murky_waters, (short)ModContent.ItemType<AbyssGravel>(), 26);
            BES.AddItemInPool(murky_waters, (short)ModContent.ItemType<PlantyMush>(), 10);
            BES.AddItemInPool(murky_waters, (short)ModContent.ItemType<Voidstone>(), 2);
            BES.AddItemInPool(murky_waters, ItemID.WhitePearl, 3);
            BES.AddItemInPool(murky_waters, ItemID.PinkPearl, 1);
            BES.AddItemInPool(murky_waters_lev, (short)ModContent.ItemType<Lumenyl>(), 20);
            BES.AddItemInPool(murky_waters_lev, (short)ModContent.ItemType<DepthCells>(), 28);
            BES.AddItemInPool(murky_waters_glm, (short)ModContent.ItemType<ScoriaOre>(), 12);

            BES.AddItemInPool(thermal_vents, ItemID.None, 26);
            BES.AddItemInPool(thermal_vents, (short)ModContent.ItemType<PyreMantle>(), 13);
            BES.AddItemInPool(thermal_vents, (short)ModContent.ItemType<PyreMantleMolten>(), 5);
            BES.AddItemInPool(thermal_vents, (short)ModContent.ItemType<ScoriaOre>(), 5);
            BES.AddItemInPool(thermal_vents, ItemID.BlackInk, 1);
            BES.AddItemInPool(thermal_vents_pla, ItemID.Ectoplasm, 2);
            BES.AddItemInPool(thermal_vents_lev, (short)ModContent.ItemType<Lumenyl>(), 13);
            BES.AddItemInPool(thermal_vents_lev, (short)ModContent.ItemType<DepthCells>(), 15);
            BES.AddItemInPool(thermal_vents_glm, (short)ModContent.ItemType<ScoriaOre>(), 5);

            BES.AddItemInPool(the_void, ItemID.None, 26); //3 lumenyl, 5 depth cells
            BES.AddItemInPool(the_void, (short)ModContent.ItemType<Voidstone>(), 26);
            BES.AddItemInPool(the_void, ItemID.BlackInk, 1);
            BES.AddItemInPool(the_void_pla, ItemID.Ectoplasm, 5);
            BES.AddItemInPool(the_void_lev, (short)ModContent.ItemType<Lumenyl>(), 9);
            BES.AddItemInPool(the_void_lev, (short)ModContent.ItemType<DepthCells>(), 14);
            BES.AddItemInPool(the_void_pgh, (short)ModContent.ItemType<ReaperTooth>(), 3);

            BES.AddItemInPool(brimstone_crag, ItemID.None, 22);
            BES.AddItemInPool(brimstone_crag, (short)ModContent.ItemType<BrimstoneSlag>(), 10);
            BES.AddItemInPool(brimstone_crag, (short)ModContent.ItemType<ScorchedRemains>(), 6);
            BES.AddItemInPool(brimstone_crag, ItemID.Lens, 3);
            BES.AddItemInPool(brimstone_crag, (short)ModContent.ItemType<SpineSapling>(), 5);
            BES.AddItemInPool(brimstone_crag_hm, (short)ModContent.ItemType<EssenceofHavoc>(), 18);
            BES.AddItemInPool(brimstone_crag_mch, (short)ModContent.ItemType<InfernalSuevite>(), 6);
            BES.AddItemInPool(brimstone_crag_prv, (short)ModContent.ItemType<Bloodstone>(), 15);
        }

        #endregion
    }
}
