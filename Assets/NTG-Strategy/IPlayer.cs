using UnityEngine;
using System.Collections;

namespace NTG
{
    public class IPlayer : ICharacter
    {
        private PlayerAttrStrategy _playerAttrStrategy;

        private PlayerAttr _PlayerAttr;

        public PlayerAttr PlayerAttr
        {
            get { return _PlayerAttr; }
            set { _PlayerAttr = ICharacterAttr as PlayerAttr; }
        }

        public BaseAttr BaseAttr;

        private int i = 1;

        void Start()
        {
            _PlayerAttr = new PlayerAttr();

            _playerAttrStrategy = new PlayerAttrStrategy();

            SetCharacterAttr(_PlayerAttr);

            Debug.Log("AttrName    " + PlayerAttr._AttrName + "    ShootSpeed    " + PlayerAttr._ShootSpeed + "    LV    " + PlayerAttr._LV + "    CurMaxEXP    " + _playerAttrStrategy.CurMaxEXP + "    CurMaxHP    " + _playerAttrStrategy.CurMaxHP + "    CurAttack    " + _playerAttrStrategy.CurAttack + "    CurDefense    " + _playerAttrStrategy.CurDefense);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
                PlayerAttr.SetLV(i);
                _playerAttrStrategy.UpdateAttr(PlayerAttr, this);
                Debug.Log("AttrName    " + PlayerAttr._AttrName + "    ShootSpeed    " + PlayerAttr._ShootSpeed + "    LV    " + PlayerAttr._LV + "    CurMaxEXP    " + _playerAttrStrategy.CurMaxEXP + "    CurMaxHP    " + _playerAttrStrategy.CurMaxHP + "    CurAttack    " + _playerAttrStrategy.CurAttack + "    CurDefense    " + _playerAttrStrategy.CurDefense);
            }
        }


        public override void SetCharacterAttr(ICharacterAttr CharacterAttr)
        {
            ICharacterAttr = CharacterAttr;
            ICharacterAttr.InitAttr(_playerAttrStrategy, this);
        }

    }


    [System.Serializable]
    public class BaseAttr
    {

        public int BaseEXP;

        public int BaseMaxHP;

        public int BaseAttack;

        public int BaseDefense;
    }
}


