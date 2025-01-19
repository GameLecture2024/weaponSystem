using UnityEngine;

namespace WeaponSystem
{
    public class RangeAttack : IAttackStrategy
    {
        public virtual void Attack()
        {
            Debug.Log("원거리 공격!");
        }
    }
}
