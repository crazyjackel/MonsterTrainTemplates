using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace $rootnamespace$
{
    class $safeitemrootname$
    {
        public static string ID = "MODNAME_$safeitemrootname$";
        public static CardData Make()
        {
            CardDataBuilder cardDataBuilder = new CardDataBuilder
            {
                CardID = ID
            };
            return cardDataBuilder.BuildAndRegister();
        }
    }
}
