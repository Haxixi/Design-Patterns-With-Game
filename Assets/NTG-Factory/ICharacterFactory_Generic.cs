using UnityEngine;
using System.Collections;

namespace NTG
{

    public interface ICharacterFactory_Generic
    {

        Player CreatePlayer<T>() where T : Player, new();

        Enemy CreateEnemy<T>() where T : Enemy, new();

    }

}


