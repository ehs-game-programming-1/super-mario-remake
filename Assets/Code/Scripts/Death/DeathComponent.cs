using System;
using UnityEngine;

public class DeathComponent : MonoBehaviour
{
    [SerializeField] private EntityType type;
    [SerializeField] private Vector3[] deathDirections;

    public Action OnDeath;

    public void Die(Vector3 direction)
    {
        foreach (var _direction in deathDirections)
        {
            if (_direction == direction)
            {
                // death animation and destroy

                OnDeath?.Invoke();

                gameObject.SetActive(false);

                Debug.Log(gameObject.name + " has died!");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DeathComponent collisionDeathComponent = collision.gameObject.GetComponent<DeathComponent>();

        if (collisionDeathComponent && collisionDeathComponent.type != type)
        {
            collisionDeathComponent.Die(collision.contacts[0].normal);
        }
    }
}

public enum EntityType
{
    Player,
    Enemy
}
