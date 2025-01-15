using UnityEngine;

[System.Serializable]
public abstract class Powerup
{
    public abstract void Consume(PlayerController controller);
}

public class MushroomPowerup : Powerup
{
    private int growSize = 2;
    
    public override void Consume(PlayerController controller)
    {
        Debug.Log( " This is a mushroom! " );

        controller.transform.localScale = Vector3.one * growSize;
    }
}

public class FireballPowerup : Powerup
{
    public int fireDamage = 10;
    
    public override void Consume(PlayerController controller)
    {
        Debug.Log( " This is a Fireball! " );
    }
}
