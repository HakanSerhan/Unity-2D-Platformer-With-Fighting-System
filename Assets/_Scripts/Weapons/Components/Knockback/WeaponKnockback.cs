using Bardent.Combat;
using UnityEngine;
using UnityEngine.Serialization;

namespace Bardent.Weapons
{
    public abstract class WeaponKnockback<T> : WeaponComponent<T> where T : WeaponComponentData
    {
        private Movement Movement => movement ?? core.GetCoreComponent(ref movement);
        private Movement movement;

        protected void CheckKnockback(GameObject obj, WeaponKnockbackStruct data)
        {
            var knockbackData = new KnockbackData(data.KnockbackAngle,
                data.KnockbackStrength, Movement.FacingDirection, gameObject);

            CombatUtilities.CheckIfKnockbackable(obj, knockbackData, out _);
        }
    }

    [System.Serializable]
    public struct WeaponKnockbackStruct : INameable
    {
        [HideInInspector] public string attackName;

        [field: SerializeField] public Vector2 KnockbackAngle { get; private set; }

        [field: SerializeField] public float KnockbackStrength { get; private set; }

        public void SetName(string value)
        {
            attackName = value;
        }
    }
}