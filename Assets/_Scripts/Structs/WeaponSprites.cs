using UnityEngine;

namespace Bardent.Weapons
{
  [System.Serializable]
  public struct WeaponSprites : INameable
  {
    [HideInInspector]
    public string AttackName;

    public AttackPhaseSprites[] AttackPhases;

    public void SetName(string value)
    {
      AttackName = value;
    }
  }

  [System.Serializable]
  public struct AttackPhaseSprites
  {
    [HideInInspector]
    public string Name;
    public WeaponAttackPhases Phase;
    public Sprite[] Sprites;
  }
}