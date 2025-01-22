using Unity.Hierarchy;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public float speed = 2.5f; // Velocità del movimento
    public Vector2 direction = Vector2.right; // Direzione iniziale (es. verso destra)
    

    void Update()
    {
        // Muove il GameObject in base alla direzione e alla velocità
        transform.Translate(-direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // sew collide con un altro oggetto cambia direzione
        if (collision.gameObject)
        {
            direction = -direction;
        }
    }

    
}
