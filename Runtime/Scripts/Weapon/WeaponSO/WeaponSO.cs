using UnityEngine;

namespace WeaponSystem
{
    [CreateAssetMenu(fileName ="WeaponProfile",menuName ="WeaponSO")]
    public class WeaponSO : ScriptableObject
    {
        public string weaponName;
        public WeaponStrategy strategy;
    }
}
