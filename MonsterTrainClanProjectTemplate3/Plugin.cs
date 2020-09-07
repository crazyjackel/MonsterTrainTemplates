using System;
using BepInEx;
using HarmonyLib;
using MonsterTrainModdingAPI.Interfaces;
using MonsterTrainClanProjectTemplate3.Cards;
using MonsterTrainClanProjectTemplate3.Champions;
using MonsterTrainClanProjectTemplate3.Characters;
using MonsterTrainClanProjectTemplate3.Clan;

namespace MonsterTrainClanProjectTemplate3
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
        public static ClassData clanARef;
        public void Initialize()
        {
            var harmony = new Harmony(MODGUID);
            harmony.PatchAll();

        }
        public void MakeClan()
        {
            clanARef = ClanA.MakeClan();
        }
        public void MakeCards()
        {
            CardA.Make();
            CharacterA.Make();
        }
        public void MakeChampions()
        {
            ChampionA.Make();
            ChampionB.Make();
        }
    }
}
