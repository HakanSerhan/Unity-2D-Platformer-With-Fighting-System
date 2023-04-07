using System;
using UnityEngine;

namespace Bardent.Combat.Interfaces
{
    public interface IHitbox
    {
        event Action<RaycastHit2D[]> OnDetected;
    }
}