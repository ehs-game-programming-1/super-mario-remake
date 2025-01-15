using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [ field: SerializeField ] public Movement Movement { get; private set; }
    [ field: SerializeField ] public MovementAnimationController AnimationController { get; private set; }
    [ field: SerializeField ] public Shooting Shooting { get; private set; }
    [ field: SerializeField ] public ScoreManager ScoreManager { get; private set; }
    
    public BoxCollider2D BoxCollider2D { get; private set; }

    private void Awake()
    {
        BoxCollider2D = GetComponent< BoxCollider2D >();
    }
}
