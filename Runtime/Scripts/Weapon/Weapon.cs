using UnityEngine;

namespace WeaponSystem
{
    public class Weapon 
    {
        private IAttackStrategy attackStrategy;

        public Weapon(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        public void Attack()
        {
            attackStrategy.Attack();
        }
    }
}
