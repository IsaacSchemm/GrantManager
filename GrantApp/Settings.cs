using System;
using System.Configuration;

namespace GrantApp {
	class Settings {
		public static bool EnableChangelog {
			get {
				return true;
			}
		}
		public static int EraseChangelogEntriesThisManyDaysOld {
			get {
				return 30;
			}
		}
	}
}
