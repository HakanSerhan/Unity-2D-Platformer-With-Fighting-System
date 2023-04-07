using UnityEngine;
using UnityEditor;
using System.Linq;
using Bardent.Weapons;

[CustomEditor(typeof(Weapon))]
public class WeaponEditor : Editor
{
  private Weapon weapon;

  public override void OnInspectorGUI()
  {
    DrawDefaultInspector();

    weapon = target as Weapon;

    if (weapon == null || weapon.WeaponData == null) return;

    if (GUILayout.Button("Set Up Weapon"))
    {
      weapon.GenerateWeapon();
    }
  }
}