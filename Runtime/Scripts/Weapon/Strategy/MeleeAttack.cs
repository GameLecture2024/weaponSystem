using UnityEngine;

namespace WeaponSystem
{
    public class MeleeAttack : IAttackStrategy
    {
        public virtual void Attack()
        {
            Debug.Log("근접 공격!");
        }
    }
}
