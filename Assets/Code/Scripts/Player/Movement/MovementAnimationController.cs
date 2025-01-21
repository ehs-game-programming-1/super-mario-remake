using UnityEngine;

public class MovementAnimationController : MonoBehaviour
{
    private Movement _movement;
    
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _movement = GetComponentInParent<Movement>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        
        _animator.SetFloat("Movement", Mathf.Abs(movement));
        _animator.SetBool("IsGrounded", _movement.IsGrounded);

        // if operation, longer but more readable
        // if ( movement < 0 )
        // {
        //     _spriteRenderer.flipX = true;
        // }
        // else
        // {
        //     _spriteRenderer.flipX = false;
        // }

        // boolean assignment, shorter but may be harder to read
        _spriteRenderer.flipX = movement < 0;

        // ternary operator, shorter but more manageable
        //_spriteRenderer.flipX = movement < 0 ? true : false;
    }

    public Animator GetAnimator()
    {
        return _animator;
    }
}
// if(switch (FireballPowerUp_on) && switch (MushroomPowerup_off)
// {
//     do this animation
    
// }
// if(switch (FireballPowerup_on) && switch (MushroomPowerup_on)
// {
//     do this animation
    
// }

