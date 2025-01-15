using UnityEngine;

[CreateAssetMenu(fileName = "Powerup_", menuName = "Powerups/New Fireball Powerup")]
public class FireballPowerup : Powerup
{
    [ SerializeField ] private GameObject gameObject;
    
    public override void Consume(PlayerController controller)
    {
        Debug.Log( " This is a Fireball! " );
    }
}