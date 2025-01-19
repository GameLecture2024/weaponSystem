using UnityEngine;

namespace WeaponSystem
{
    [System.Serializable]
    public class WeaponStrategy
    {
        public AttackType strategyType;

        public IAttackStrategy GetWeaponStrategy
        {
            get
            {
                return CreateAttackStrategy(strategyType);
            }
        }

        public IAttackStrategy CreateAttackStrategy(AttackType type)
        {
            switch (type)
            {
                case AttackType.Melee:
                    return new MeleeAttack();
                case AttackType.Range:
                    return new RangeAttack();
                default:
                    throw new System.ArgumentException("Invalid attack type");
            }
        }
    }

    public enum AttackType
    {
        Melee,
        Range
    }
}