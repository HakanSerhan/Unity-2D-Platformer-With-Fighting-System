using System.Collections;
using System.Collections.Generic;
using Bardent.Weapons;
using UnityEngine;

public interface IKnockbackable 
{
    void Knockback(KnockbackData data);
}

public struct KnockbackData
{
    public Vector2 Angle;
    public float Strength;

    public KnockbackData(Vector2 angle, float strength, int direction, GameObject source)
    {
        Angle = angle;
        Strength = strength;
        Direction = direction;
        this.Source = source;
    }

    public int Direction;
    public GameObject Source;
}
