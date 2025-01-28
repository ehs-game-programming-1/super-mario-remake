using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    private DeathComponent _deathComponent;
    private Animator _animator;

    private void Awake()
    {
        _deathComponent = GetComponent< DeathComponent >();
        _animator = GetComponentInChildren< Animator >();
    }

    private void OnEnable() => _deathComponent.OnDeath += PlayAnimation;
    private void OnDisable() => _deathComponent.OnDeath -= PlayAnimation;

    protected virtual void PlayAnimation() 
    {
        _animator.SetBool("IsDead", true);
    }
}