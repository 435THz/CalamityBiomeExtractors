using Terraria.ModLoader;

namespace CalamityBiomeExtractors
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class CalamityBiomeExtractors : Mod
    {
        public static CalamityBiomeExtractors Instance => ModContent.GetInstance<CalamityBiomeExtractors>();
        
        private static readonly string LocBase = "Mods.CalamityBiomeExtractors";

        private static string LocItemsCategory => $"{LocBase}.Items";
        private static string LocItemsExtractor(string variant) => $"{LocItemsCategory}.{variant}ExtractorItem";
        public static string LocItemsExtractorName(string variant) => $"{LocItemsExtractor(variant)}.DisplayName";
        public static string LocItemsExtractorDescr(string variant) => $"{LocItemsExtractor(variant)}.Tooltip";

        private static string LocTextCategory => $"{LocBase}.Text";
        public static string LocPoolNames => $"{LocTextCategory}.PoolNames";
        public static string LocArticles => $"{LocTextCategory}.Articles";
        public static string LocTiers => $"{LocTextCategory}.Tiers";

    }
}
