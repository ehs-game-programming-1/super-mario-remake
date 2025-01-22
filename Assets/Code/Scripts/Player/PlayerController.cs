using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [ field: SerializeField ] public Movement Movement { get; private set; }
    [ field: SerializeField ] public MovementAnimationController AnimationController { get; private set; }
    [ field: SerializeField ] public Shooting Shooting { get; private set; }
    [ field: SerializeField ] public ScoreManager ScoreManager { get; private set; }
    
    public BoxCollider2D BoxCollider2D { get; private set; }

    private void Awake()
    {
        BoxCollider2D = GetComponent< BoxCollider2D >();
    }

    // Metodo che viene chiamato quando il Goomba entra in collisione con un altro oggetto
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se l'oggetto che ha causato la collisione è il giocatore
        if (collision.collider.CompareTag("Enemy"))
        {
            // Stampa un messaggio di debug
            Debug.Log("GAME OVER!");

            // Distrugge il Goomba (l'oggetto su cui è allegato questo script)
            Destroy(gameObject);
        }
    }



}

