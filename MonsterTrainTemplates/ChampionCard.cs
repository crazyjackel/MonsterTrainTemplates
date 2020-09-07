using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace $rootnamespace$
{
    class $safeitemrootname$
    {
        public const string ID = "MODNAME_$safeitemrootname$";
        public static CardData Make()
        {
            ChampionCardDataBuilder championCardDataBuilder = new ChampionCardDataBuilder
            {
                CardID = ID,
                Champion = GetCharacterDataBuilder(),
                UpgradeTree = GetUpgradeTreeDataBuilder()
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
