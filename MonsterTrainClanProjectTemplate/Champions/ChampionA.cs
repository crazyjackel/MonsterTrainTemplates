using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace $safeprojectname$.Champions
{
    class ChampionA
    {
        public const string ID = "MODNAME_ChampionA";
        public static CardData Make()
        {
            ChampionCardDataBuilder championCardDataBuilder = new ChampionCardDataBuilder
            {
                CardID = ID,
                Champion = GetCharacterDataBuilder(),
                UpgradeTree = GetUpgradeTreeDataBuilder(),
                LinkedClass = Plugin.clanARef
            };
            return championCardDataBuilder.BuildAndRegister();
        }
        public static CardUpgradeTreeDataBuilder GetUpgradeTreeDataBuilder()
        {
            CardUpgradeTreeDataBuilder cardUpgradeTreeDataBuilder = new CardUpgradeTreeDataBuilder
            {
                UpgradeTrees = new List<List<CardUpgradeDataBuilder>>
                {
                    new List<CardUpgradeDataBuilder>
                    {

                    },
                    new List<CardUpgradeDataBuilder>
                    {

                    },
                    new List<CardUpgradeDataBuilder>
                    {

                    }
                }
            };
            return cardUpgradeTreeDataBuilder;
        }
        public static CharacterDataBuilder GetCharacterDataBuilder()
        {
            CharacterDataBuilder characterDataBuilder = new CharacterDataBuilder
            {
                CharacterID = ID
            };
            return characterDataBuilder;
        }
    }
}
