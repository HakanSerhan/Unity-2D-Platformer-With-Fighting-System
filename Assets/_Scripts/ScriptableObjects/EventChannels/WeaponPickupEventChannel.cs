﻿using System;
using Bardent.Weapons;
using UnityEngine;

namespace Bardent.EventChannels
{
    [CreateAssetMenu(fileName = "newWeaponPickupChannel", menuName = "Event Channels/Weapon Pickup")]
    public class WeaponPickupEventChannel : EventChannelsSO<WeaponPickupEventArgs>
    {
    }

    public class WeaponPickupEventArgs : EventArgs
    {
        public WeaponDataSO NewWeaponData;
        public WeaponDataSO PrimaryWeaponData;
        public WeaponDataSO SecondaryWeaponData;

        public WeaponPickupEventArgs(WeaponDataSO newWeaponData, WeaponDataSO primaryWeaponData, WeaponDataSO secondaryWeaponData)
        {
            NewWeaponData = newWeaponData;
            PrimaryWeaponData = primaryWeaponData;
            SecondaryWeaponData = secondaryWeaponData;
        }
    }
}