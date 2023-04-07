﻿using UnityEngine;

namespace Bardent.Weapons
{
    [System.Serializable]
    public struct ChargeProjectileSpawnModifierStruct : INameable
    {
        [HideInInspector] public string Name;
        public float AngleVariation;

        public void SetName(string value)
        {
            Name = value;
        }
    }
}