using UnityEngine;
using System.Collections;

namespace NTG
{
    /// <summary>
    /// 角色基类
    /// </summary>
    public abstract class Character
    {

    }


    public class Player : Character
    {
        public Player()
        {
            Debug.Log("生成Player");
        }

        public void CreatePlayer(int num)
        {
            //生成预制体(池加载)
            for (int i = 0; i < num; i++)
            {
                Debug.Log(11);   
            }
        }


    }


    public class Enemy : Character
    {
        public Enemy()
        {
            Debug.Log("生成Enemy");
        }

        public void CreateEnemy(int num)
        {
            //生成预制体(池加载)
            for (int i = 0; i < num; i++)
            {
                Debug.Log(22);
            }
        }
    }
}

