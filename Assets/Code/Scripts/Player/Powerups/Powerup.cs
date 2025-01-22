using UnityEngine;

public abstract class Powerup : ScriptableObject
{
    [ field: SerializeField, Range(-1, 10)] public int Priority { get; private set; } 
    [ SerializeField ] protected AnimatorOverrideController overrideController;

    public abstract void Consume(PlayerController controller);
}