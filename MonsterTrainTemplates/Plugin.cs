using System;
using BepInEx;
using HarmonyLib;
using MonsterTrainModdingAPI.Interfaces;

namespace $safeprojectname$
{
    [BepInPlugin(MODGUID, MODNAME, VERSION)]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("api.modding.train.monster")]
    public class $safeitemname$ : BaseUnityPlugin, IInitializable
    {
        public const string MODGUID = "domain.username.modname";
        public const string MODNAME = "modname";
        public const string VERSION = "0.0";
        public void Initialize()
        {
            var harmony = new Harmony(MODGUID);
            harmony.PatchAll();
        }
    }
}
