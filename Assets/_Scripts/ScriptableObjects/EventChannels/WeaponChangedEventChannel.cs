using System;
using Bardent.Weapons;
using UnityEngine;

namespace Bardent.EventChannels
{
    [CreateAssetMenu(fileName = "newWeaponChangedChannel", menuName = "Event Channels/Weapon Changes")]
    public class WeaponChangedEventChannel : EventChannelsSO<WeaponChangedEventArgs>{ }

    public class WeaponChangedEventArgs : EventArgs
    {
        public WeaponDataSO WeaponData;
        public CombatInputs WeaponInput;

        public WeaponChangedEventArgs(WeaponDataSO weaponData, CombatInputs weaponInput)
        {
            WeaponData = weaponData;
            WeaponInput = weaponInput;
        }
    }
}