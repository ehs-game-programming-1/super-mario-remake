using UnityEngine;

public abstract class Powerup : ScriptableObject
{
    public abstract void Consume(PlayerController controller);
}