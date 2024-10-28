using HarmonyLib;

namespace AutoScroll
{
  [HarmonyPatch(typeof(Terminal))]
  public static class TerminalStartPatch
  {
    [HarmonyPatch("Start")]
    [HarmonyPostfix]
    internal static void GameMethodPatch(StartOfRound __instance)
    {
      // Ship monitor auto scrolling for long texts
      StartOfRound.Instance.screenLevelDescription.gameObject.AddComponent<AutoScrollText>();
    }
  }
}
