using UnityEngine;
using System.Collections;
using System;

namespace NTG
{

    public class PlayerAttrStrategy : IAttrStrategy
    {
        public int CurAttack;

        public int CurDefense;

        public int CurMaxHP;

        public int CurMaxEXP;

        public override void InitAttr(ICharacterAttr CharacterAttr, ICharacter IC)
        {
            PlayerAttr playerAttr = CharacterAttr as PlayerAttr;

            IPlayer player = IC as IPlayer;

            if (playerAttr == null || player == null)
            {
                return;
            }

            CurAttack = GetAttackPlus(CharacterAttr, IC);

            CurDefense = GetDefensePlus(CharacterAttr, IC);

            CurMaxHP = GetMaxHP(CharacterAttr, IC);

            CurMaxEXP = GetLevelMaxEXP(CharacterAttr, IC);
        }

        public override void UpdateAttr(ICharacterAttr CharacterAttr, ICharacter IC)
        {

            PlayerAttr playerAttr = CharacterAttr as PlayerAttr;

            IPlayer player = IC as IPlayer;

            if (playerAttr == null || player == null)
            {
                return;
            }

            CurAttack = GetAttackPlus(CharacterAttr, IC);

            CurDefense = GetDefensePlus(CharacterAttr, IC);

            CurMaxHP = GetMaxHP(CharacterAttr, IC);

            CurMaxEXP = GetLevelMaxEXP(CharacterAttr, IC);
        }

        public override int GetLevelMaxEXP(ICharacterAttr CharacterAttr, ICharacter IC)
        {
            PlayerAttr playerAttr = CharacterAttr as PlayerAttr;

            IPlayer player = IC as IPlayer;

            if (playerAttr == null || player == null)
            {
                return 0;
            }

            int LV = playerAttr.GetLV();

            if (LV >= 1)
            {
                CurMaxEXP = player.BaseAttr.BaseEXP + (LV - 1) * 100;
            }

            return CurMaxEXP;
        }

        public override int GetAttackPlus(ICharacterAttr CharacterAttr, ICharacter IC)
        {
            PlayerAttr playerAttr = CharacterAttr as PlayerAttr;

            IPlayer player = IC as IPlayer;

            if (playerAttr == null || player == null)
            {
                return 0;
            }

            int LV = playerAttr.GetLV();

            if (LV >= 1)
            {
                CurAttack = player.BaseAttr.BaseAttack + (LV - 1) * 100;
            }

            return CurAttack;
        }

        public override int GetDefensePlus(ICharacterAttr CharacterAttr, ICharacter IC)
        {
            PlayerAttr playerAttr = CharacterAttr as PlayerAttr;

            IPlayer player = IC as IPlayer;

            if (playerAttr == null || player == null)
            {
                return 0;
            }

            int LV = playerAttr.GetLV();

            if (LV >= 1)
            {
                CurDefense = player.BaseAttr.BaseDefense + (LV - 1) * 50;
            }

            return CurDefense;

        }

        public override int GetMaxHP(ICharacterAttr CharacterAttr, ICharacter IC)
        {
            PlayerAttr playerAttr = CharacterAttr as PlayerAttr;

            IPlayer player = IC as IPlayer;

            if (playerAttr == null || player == null)
            {
                return 0;
            }

            int LV = playerAttr.GetLV();

            if (LV >= 1)
            {
                CurMaxHP = player.BaseAttr.BaseMaxHP + (LV - 1) * 100;
            }

            return CurMaxHP;
        }
    }

}

