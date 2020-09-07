using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace $rootnamespace$
{
    class CardA
{
    public const string ID = "MODNAME_CardA";
    public static CardData Make()
    {
        CardDataBuilder cardDataBuilder = new CardDataBuilder
        {
            CardID = ID,
            LinkedClass = Plugin.clanARef
        };
        return cardDataBuilder.BuildAndRegister();
    }
}
}
