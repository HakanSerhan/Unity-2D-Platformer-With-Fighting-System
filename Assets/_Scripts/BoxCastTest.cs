using System.Collections;
using System.Collections.Generic;
using Bardent.Utilities;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BoxCastTest : MonoBehaviour
{
  [SerializeField] private BoxCollider2D hitbox;
  [SerializeField] private LayerMask whatIsGround;

  private RaycastHit2D[] hits;

  private void FixedUpdate()
  {
    Debug.Log($"Angle: {transform.rotation.eulerAngles.z}");

    hits = Physics2D.BoxCastAll(
      transform.position,
      hitbox.size,
      transform.rotation.eulerAngles.z,
      transform.right,
      1.5f,
      whatIsGround);
  }

  private void Awake()
  {
    hitbox = GetComponent<BoxCollider2D>();
  }

  private void OnDrawGizmos()
  {
    if (hits == null) return;

    foreach (var item in hits)
    {
      Debug.DrawRay(item.point, item.normal, Color.red, 0.75f);
    }
  }
}
