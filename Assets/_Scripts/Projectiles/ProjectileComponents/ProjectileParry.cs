using Bardent.Combat.Interfaces;
using UnityEngine;

namespace Bardent.Projectiles
{
    public class ProjectileParry : ProjectileComponent<ProjectileParryData>, IParryable
    {
        private BoxCollider2D parryCollider;

        public override void SetReferences()
        {
            base.SetReferences();

            var childGo = new GameObject();

            childGo.name = "ParryCollider";
            childGo.transform.parent = transform;
            childGo.transform.localPosition = Vector3.zero;
            childGo.layer = LayerMask.NameToLayer("Parryable");

            var handler = childGo.AddComponent<ParryableCollider>();
            handler.SetHandler(this);

            parryCollider = childGo.AddComponent<BoxCollider2D>();
            parryCollider.size = Data.ColliderInfo.size;
            parryCollider.offset = Data.ColliderInfo.position;
            parryCollider.isTrigger = true;

            Data = Projectile.Data.GetComponentData<ProjectileParryData>();
        }

        public void Parry(Combat.Interfaces.ParryData data)
        {
            print("Projectile Parried");

            var dir = (Vector2)(Projectile.SpawningEntity.transform.position - transform.position);

            // Spawn the parried version of the projectile
            // Direct new projectile towards entity that shot the original projectile
            var parriedProjectile = Instantiate(
                Data.ParryGameObject,
                transform.position,
                Quaternion.Euler(0f, 0f, Utilities.VectorUtilities.AngleFromVector2(dir))
            );

            var projectileScript = parriedProjectile.GetComponent<Projectile>();
            projectileScript.CreateProjectile(Data.ParryProjectileData);
            projectileScript.Init(data.source);

            Destroy(gameObject);

        }

        public GameObject GetParent()
        {
            return gameObject;
        }
    }

    public class ProjectileParryData : ProjectileComponentData
    {
        [field: SerializeField] public GameObject ParryGameObject { get; private set; }
        [field: SerializeField] public ProjectileDataSO ParryProjectileData { get; private set; }
        [field: SerializeField] public Rect ColliderInfo { get; private set; }

        public ProjectileParryData()
        {
            ComponentDependencies.Add(typeof(ProjectileParry));
        }
    }
}