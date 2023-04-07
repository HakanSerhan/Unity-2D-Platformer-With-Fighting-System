using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bardent.Weapons
{
  [System.Serializable]
  public struct DrawStruct : INameable
  {
    [HideInInspector]
    public string Name;
    public AnimationCurve curve;
    public float drawTime;

    public void SetName(string value)
    {
      Name = value;
    }
  }
}
