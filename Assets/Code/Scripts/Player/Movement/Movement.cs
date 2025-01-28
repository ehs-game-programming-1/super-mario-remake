using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField] private MovementSettings settings;
    
    private Rigidbody2D _rigidBody;

    [field: SerializeField] public bool IsGrounded { get; private set; }
    
    private void Awake() => _rigidBody = GetComponent<Rigidbody2D>();

    private void Update() {
        
        if (Input.GetButtonDown("Jump") && IsGrounded) {
            
            AddForce(Vector2.up, settings.jumpForce, 1, ForceMode2D.Impulse);
            IsGrounded = false;
        }
        
    }

    private void FixedUpdate() {
        
        float horizontal = Input.GetAxis("Horizontal");
        
        AddForce(Vector2.right, settings.walkSpeed, horizontal);
        
        // Clamp the velocity to the max speed
        // Clamping means that if the value is higher than the max speed, it will be set to the max speed and if it's lower than the max speed, it will stay the same
        _rigidBody.linearVelocityX = Mathf.Clamp(_rigidBody.linearVelocityX, -settings.maxSpeed, settings.maxSpeed);
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        
        // Check if the player is grounded by checking if the normal of the collision is pointing upwards
        // Dot product is a mathematical operation that returns a value between -1 and 1 based on the angle between two vectors
        // If the angle is 0, the dot product will return 1 and if the angle is 90 degrees, the dot product will return 0
        if (Vector2.Dot(other.contacts[0].normal, Vector2.up) > 0.5f) {
            IsGrounded = true;
        }
        
    }

    public void AddForce( Vector2 direction, float force, float axis = 1, ForceMode2D forceMode2D = ForceMode2D.Force ) => _rigidBody.AddForce(direction * (axis * force), forceMode2D);
}
