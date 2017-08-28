using UnityEngine;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace NTG
{
    public abstract class ICharacterAttr
    {
        /// <summary>
        /// 共有属性
        /// </summary>
        public string _AttrName;

        /// <summary>
        /// 初始化属性计算
        /// </summary>
        /// <param name="IAttrStrategy"></param>
        public virtual void InitAttr(IAttrStrategy IAttrStrategy, ICharacter IC)
        {
            IAttrStrategy.InitAttr(this, IC);
        }

        public virtual void SetAttrName(string AttrName)
        {
            _AttrName = AttrName;
        }

        public virtual string GetAttrName()
        {
            return _AttrName;
        }

    }
}


