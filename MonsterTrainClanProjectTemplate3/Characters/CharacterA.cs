using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace MonsterTrainClanProjectTemplate3.Characters
{
    public class CharacterA
    {
        public const string ID = "MODNAME_CharacterA";
        public static CardData Make()
        {
            CardDataBuilder cardDataBuilder = new CardDataBuilder
            {
                CardID = ID,
                LinkedClass = Plugin.clanARef,
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
