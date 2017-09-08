using UnityEngine;
using System.Collections;


namespace NTG
{

    public static class NTGFactory
    {

        private static CharacterFactory_Generic characterFactory_Generic;

        public static ICharacterFactory_Generic GetCharacterFactoryGeneric()
        {
            if (characterFactory_Generic == null)
                characterFactory_Generic = new CharacterFactory_Generic();
            
            return characterFactory_Generic;

        }
    }

}

