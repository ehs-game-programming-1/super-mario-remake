using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [ SerializeField ] private float speed;

    [ SerializeField ] private float lifeTime = 10f;
    private float _currentLifeTime = 0;

    private Rigidbody2D _rigidbody;
    private Vector2 _direction = Vector2.zero;

    private void Awake() => _rigidbody = GetComponent< Rigidbody2D >();
    public void SetVelocity(Vector2 direction) => _direction = new Vector2(direction.x, 0);
    private void FixedUpdate() => _rigidbody.linearVelocity = _direction * speed;

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if ( _currentLifeTime >= lifeTime )
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D( Collision2D other ) => Destroy(gameObject);
}
