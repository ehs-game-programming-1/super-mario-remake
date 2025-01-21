using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed;
    private int HP = 1;
    private float moveDirection = 1;

    private Rigidbody2D _rigidBody;

    private Animator _animator;


void Awake()
{
    _rigidBody = GetComponent<Rigidbody2D>();
    _animator = GetComponent<Animator>();
}

 void FixedUpdate()
 {
    _rigidBody.AddForce(Vector2.right * moveDirection * movementSpeed * Time.deltaTime);   

 }

 private void OnCollisionEnter2D(Collision2D other)
 {
    //  moveDirection = -moveDirection; 

    if (Vector2.Dot(other.contacts[0].normal, Vector2.left) > 0.1f)
    {
    moveDirection = -moveDirection;   
    } 
     if (Vector2.Dot(other.contacts[0].normal, Vector2.right) > 0.1f)
    {
    moveDirection = -moveDirection;   
    } 
 }    
}
