using UnityEngine;

public class MovementAnimationController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        
        animator.SetFloat("Movement", Mathf.Abs(movement));
    }
}
