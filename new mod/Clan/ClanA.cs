using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace $rootnamespace$
{
    class ClanA
{
    public const string ID = "MODNAME";
    public static ClassData MakeClan()
    {
        ClassDataBuilder classDataBuilder = new ClassDataBuilder
        {
            ClassID = ID,
        };
        return classDataBuilder.BuildAndRegister();
    }
}
}
