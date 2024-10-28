﻿using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace AutoScroll
{
	[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
	[BepInDependency("MrovLib", BepInDependency.DependencyFlags.SoftDependency)]
	public class Plugin : BaseUnityPlugin
	{
		internal static ManualLogSource logger;
		internal static Harmony harmony = new(PluginInfo.PLUGIN_GUID);

		private void Awake()
		{
			logger = Logger;
			harmony.PatchAll();

			// Plugin startup logic
			Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
		}
	}
}