using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    private DeathComponent _deathComponent;

    private void Awake() => _deathComponent = GetComponent<DeathComponent>();

    private void OnEnable() => _deathComponent.OnDeath += PlayAnimation;
    private void OnDisable() => _deathComponent.OnDeath -= PlayAnimation;

    void PlayAnimation() 
    {
        
    }
}
