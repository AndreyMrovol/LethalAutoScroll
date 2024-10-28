using HarmonyLib;
using TMPro;

namespace AutoScroll
{
	[HarmonyPatch(typeof(StartOfRound))]
	public static class SetMapScreenInfoToCurrentLevelPatch
	{
		[HarmonyPatch("SetMapScreenInfoToCurrentLevel")]
		[HarmonyPostfix]
		[HarmonyPriority(Priority.Last)]
		[HarmonyAfter("mrov.WeatherRegistry")]
		internal static void GameMethodPatch(StartOfRound __instance)
		{
			AutoScrollText obj = __instance.screenLevelDescription.GetComponent<AutoScrollText>();
			obj?.ResetScrolling();
		}
	}
}
