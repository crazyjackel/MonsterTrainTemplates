using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;

namespace $rootnamespace$
{
    public class $safeitemrootname$
    {
        public const string ID = "MODNAME_$safeitemrootname$";
        public static CardData Make()
        {
            CardDataBuilder cardDataBuilder = new CardDataBuilder
            {
                CardID = ID,
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = typeof(CardEffectSpawnMonster),
                        ParamCharacterDataBuilder = GetCharacterDataBuilder()
                    }
                }
            };
            return cardDataBuilder.BuildAndRegister();
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
