using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;

namespace $rootnamespace$
{
    class $safeitemrootname$
    {
        public const string ID = "MODNAME_$safeitemrootname$";
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
