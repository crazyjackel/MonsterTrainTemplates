using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;

namespace $safeprojectname$.Clan
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
