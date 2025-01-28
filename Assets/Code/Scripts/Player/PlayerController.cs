using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [ field: SerializeField ] public Movement Movement { get; private set; }
    [ field: SerializeField ] public MovementAnimationController AnimationController { get; private set; }
    [ field: SerializeField ] public Shooting Shooting { get; private set; }
    [ field: SerializeField ] public ScoreManager ScoreManager { get; private set; }
    [ field: SerializeField ] public DeathComponent DeathComponent { get; private set; }
    
    [ field: SerializeField ] public Powerup ActivePowerup { get; set; }
    
    public BoxCollider2D BoxCollider2D { get; private set; }

    private void Awake() => BoxCollider2D = GetComponent< BoxCollider2D >();
    private void Start() => ActivePowerup.Consume(this);

    private void OnEnable() => DeathComponent.OnDeath += DisableScripts;
    private void OnDisable() => DeathComponent.OnDeath -= DisableScripts;

    private void DisableScripts()
    {
        Movement.AddForce(Vector2.up, 7, 1, ForceMode2D.Impulse);
        
        Movement.enabled = false;
        Shooting.enabled = false;
        AnimationController.enabled = false;

        BoxCollider2D.enabled = false;
    }

    public bool IsHigherPriority(Powerup powerup) => ActivePowerup.Priority > powerup.Priority;
}
