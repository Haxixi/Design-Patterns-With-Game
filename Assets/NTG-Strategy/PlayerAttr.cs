using UnityEngine;
using System.Collections;

namespace NTG
{
    public class PlayerAttr : ICharacterAttr
    {
        /// <summary>
        /// 特有属性_变化
        /// </summary>
        public int _LV;

        /// <summary>
        /// 特有属性_不变
        /// </summary>
        public float _ShootSpeed;

        public PlayerAttr()
        {
            SetLV(1);
            SetShootSpeed(5);
            SetAttrName("PLAYER");
        }

        public void SetLV(int LV)
        {
            _LV = LV;
        }

        public int GetLV()
        {
            return _LV;
        }

        public void SetShootSpeed(float ShootSpeed)
        {
            _ShootSpeed = ShootSpeed;
        }

        public float GetShootSpeed()
        {
            return _ShootSpeed;
        }
    }

}


