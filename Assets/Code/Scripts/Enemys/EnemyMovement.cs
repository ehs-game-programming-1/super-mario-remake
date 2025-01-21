
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;  // Speed of the Goomba's movement
    private bool movingRight = true; // Direction in which Goomba moves

    // Move the Goomba back and forth
    private void MoveGoomba()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
    // When Goomba collides with Mario
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if Mario jumps on top of the Goomba
            if (collision.contacts[0].normal.y > 0.5f)  // Mario hit the Goomba from above
            {
                // Destroy Goomba when Mario jumps on it
                Destroy(gameObject);
            }
            else
            {
                // Goomba kills Mario if Mario hits it from the side or below
                collision.gameObject.GetComponent<PlayerController>().Die();
            }
        }
    }
}


