using Unity.Hierarchy;
using UnityEngine;

public class GoombaDeath : MonoBehaviour
{
    private Animator animator;  // Riferimento all'Animator del Goomba
    private bool isSquashed = false;  // Variabile per tenere traccia se il Goomba è schiacciato

    void Start()
    {
        animator = GetComponent<Animator>();  // Ottieni il componente Animator
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se il Goomba è stato colpito dal giocatore
        if (collision.collider.CompareTag("Player"))
        {
            // Verifica se il Goomba è stato colpito dall'alto
            if (collision.contacts[0].normal.y > 0)  // Contatto dalla parte superiore
            {
                // Cambia lo stato e imposta l'animazione schiacciata
                if (!isSquashed)
                {
                    isSquashed = true;
                    animator.SetTrigger("Squashed");  // Attiva l'animazione schiacciata
                }
            }
        }
    }

}
