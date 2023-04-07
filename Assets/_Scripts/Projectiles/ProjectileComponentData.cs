using System;
using System.Collections.Generic;
using UnityEngine;

namespace Bardent.Projectiles
{
  [System.Serializable]
  public class ProjectileComponentData
  {
    private List<Type> componentDependencies = new List<Type>();
    // Used to attach right component to GO
    public List<Type> ComponentDependencies { get => componentDependencies; protected set => componentDependencies = value; }
    
    public ProjectileComponentData()
    {
      this.name = this.GetType().Name; ;
    }

    [SerializeField, HideInInspector]
    protected string name = "TEST";
  }
}