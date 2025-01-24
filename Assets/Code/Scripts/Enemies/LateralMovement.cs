using System;
using UnityEngine;

public class LateralMovement : MonoBehaviour
{
    [ SerializeField ] private float speed = 5f;

    [ SerializeField ] private LayerMask rayMask;
    [ SerializeField ] private float rayDistance = 5f;

    private BoxCollider2D _collider;
    private Rigidbody2D _rigidbody;
    private Vector3 _direction = Vector3.left;

    private Vector3 OffsetPosition => new (transform.position.x + ( (_collider.size.x * 0.5f) + 0.05f ) * _direction.x, transform.position.y + 0.5f, 0 );
    
    private void Awake()
    {
        _rigidbody = GetComponent< Rigidbody2D >();
        _collider = GetComponent< BoxCollider2D >();
    }

    private void Update()
    {
        if ( Physics2D.Raycast(OffsetPosition, _direction, rayDistance, rayMask) )
        {
            _direction = _direction == Vector3.right ? Vector3.left : Vector3.right;
        }
    }

    private void FixedUpdate() => _rigidbody.linearVelocity = _direction * speed;

    private void OnDrawGizmos()
    {
        if ( !_collider ) _collider = GetComponent< BoxCollider2D >();
        
        Gizmos.color = Color.magenta;
        Gizmos.DrawRay(OffsetPosition, _direction * rayDistance);
    }
}
