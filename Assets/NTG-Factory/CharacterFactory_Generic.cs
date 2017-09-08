using UnityEngine;
using System.Collections;
using System;

namespace NTG
{

    public class CharacterFactory_Generic : ICharacterFactory_Generic
    {
        public Enemy CreateEnemy<T>() where T : Enemy, new()
        {
            Debug.Log("1");

            Enemy enemy = new T();

            if (enemy == null)
                return null;

            return enemy;
        }

        public Player CreatePlayer<T>() where T : Player, new()
        {
            Debug.Log("2");

            Player player = new T();

            if (player == null)
                return null;

            return player;
        }
    }

}


