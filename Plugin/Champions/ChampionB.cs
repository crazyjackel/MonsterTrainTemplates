using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace $safeprojectname$.Champions
{
    class ChampionB
    {
        public const string ID = "MODNAME_ChampionB";
        public static CardData Make()
        {
            ChampionCardDataBuilder championCardDataBuilder = new ChampionCardDataBuilder
            {
                CardID = ID,
                Champion = GetCharacterDataBuilder(),
                UpgradeTree = GetUpgradeTreeDataBuilder(),
                LinkedClass = Plugin.clanARef
            };
            return championCardDataBuilder.BuildAndRegister(1);
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
