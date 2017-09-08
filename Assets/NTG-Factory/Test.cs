using UnityEngine;
using System.Collections;

namespace NTG
{
    public class Test : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            NTGFactory.GetCharacterFactoryGeneric().CreatePlayer<Player>().CreatePlayer(5);
            NTGFactory.GetCharacterFactoryGeneric().CreateEnemy<Enemy>().CreateEnemy(10);
        }
    }

}


