using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField] private MovementSettings settings;
    
    private Rigidbody2D _rigidBody;

    private bool _isGrounded;
    
    private void Awake() => _rigidBody = GetComponent<Rigidbody2D>();

    private void Update() {
        
        if (Input.GetButtonDown("Jump") && _isGrounded) {
            _rigidBody.AddForce(Vector2.up * settings.jumpForce, ForceMode2D.Impulse);
            _isGrounded = false;
        }
        
    }

    private void FixedUpdate() {
        
        float horizontal = Input.GetAxis("Horizontal");
        
        _rigidBody.AddForce(Vector2.right * (horizontal * settings.walkSpeed));
        
        // Clamp the velocity to the max speed
        // Clamping means that if the value is higher than the max speed, it will be set to the max speed and if it's lower than the max speed, it will stay the same
        _rigidBody.linearVelocityX = Mathf.Clamp(_rigidBody.linearVelocityX, -settings.maxSpeed, settings.maxSpeed);
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        
        // Check if the player is grounded by checking if the normal of the collision is pointing upwards
        // Dot product is a mathematical operation that returns a value between -1 and 1 based on the angle between two vectors
        // If the angle is 0, the dot product will return 1 and if the angle is 90 degrees, the dot product will return 0
        if (Vector2.Dot(other.contacts[0].normal, Vector2.up) > 0.5f) {
            _isGrounded = true;
        }
        
    }
}
