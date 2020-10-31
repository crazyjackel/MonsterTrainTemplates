using System;
using BepInEx;
using HarmonyLib;
using Trainworks.Interfaces;

namespace $safeprojectname$
{
    [BepInPlugin(MODGUID, MODNAME, VERSION)]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("api.modding.train.monster")]
    public class Plugin : BaseUnityPlugin, IInitializable
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
