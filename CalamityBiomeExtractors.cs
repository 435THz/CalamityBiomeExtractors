using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.Social.WeGame;

namespace CalamityBiomeExtractors
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class CalamityBiomeExtractors : Mod
    {
        private static readonly object LocBase = "Mods.CalamityBiomeExtractors";

        private static string LocTextCategory => $"{LocBase}.Text";
        public static string LocPoolNames => $"{LocTextCategory}.PoolNames";

    }
}
