using UnityEngine;
using System.Collections;

namespace NTG
{
    public abstract class IAttrStrategy
    {
        /// <summary>
        /// 初始数值
        /// </summary>
        /// <param name="CharacterAttr"></param>
        public abstract void InitAttr(ICharacterAttr CharacterAttr, ICharacter IC);

        /// <summary>
        /// 攻击属性
        /// </summary>
        public abstract int GetAttackPlus(ICharacterAttr CharacterAttr, ICharacter IC);

        /// <summary>
        /// 防御属性
        /// </summary>
        /// <param name="CharacterAttr"></param>
        public abstract int GetDefensePlus(ICharacterAttr CharacterAttr, ICharacter IC);

        /// <summary>
        /// 血量属性
        /// </summary>
        /// <param name="CharacterAttr"></param>
        /// <returns></returns>
        public abstract int GetMaxHP(ICharacterAttr CharacterAttr, ICharacter IC);

        /// <summary>
        /// 经验属性
        /// </summary>
        /// <param name="CharacterAttr"></param>
        /// <returns></returns>
        public abstract int GetLevelMaxEXP(ICharacterAttr CharacterAttr, ICharacter IC);

        /// <summary>
        /// 更新数据
        /// </summary>
        public abstract void UpdateAttr(ICharacterAttr CharacterAttr, ICharacter IC);
    }
}


