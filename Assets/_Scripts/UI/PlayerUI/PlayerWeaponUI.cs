using System;
using System.Collections;
using System.Collections.Generic;
using Bardent.EventChannels;
using Bardent.Weapons;
using UnityEngine;
using UnityEngine.UI;

namespace Bardent.UI
{
    public class PlayerWeaponUI : MonoBehaviour
    {
        [SerializeField] private CombatInputs input;
        [SerializeField] private WeaponChangedEventChannel channel;

        private Image weaponIcon;

        private void Awake()
        {
            weaponIcon = GetComponent<Image>();
            weaponIcon.color = Color.clear;
        }

        private void OnEnable() => channel.OnEvent += HandleWeaponChangeEvent;
        private void OnDisable() => channel.OnEvent -= HandleWeaponChangeEvent;

        private void HandleWeaponChangeEvent(object sender, WeaponChangedEventArgs context)
        {
            if (context.WeaponInput == input && weaponIcon)
            {
                weaponIcon.sprite = context.WeaponData.PickupSprite;
                weaponIcon.color = Color.white;
            }   
        }
    }
}
