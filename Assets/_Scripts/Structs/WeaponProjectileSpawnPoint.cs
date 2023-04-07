using Bardent.Projectiles;
using UnityEngine;

namespace Bardent.Weapons
{
  [System.Serializable]
  public struct WeaponProjectileSpawnPoint
  {
    public Vector2 offset;
    public Vector2 direction;
    public ProjectileDataSO projectileData;
  }
}