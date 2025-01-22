using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [ SerializeField ] private float speed;

    private Rigidbody2D _rigidbody;
    private Vector2 _direction = Vector2.zero;

    private void Awake() => _rigidbody = GetComponent< Rigidbody2D >();
    public void SetVelocity(Vector2 direction) => _direction = new Vector2(direction.x, 0);
    private void FixedUpdate() => _rigidbody.linearVelocity = _direction * speed;
}
