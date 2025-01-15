using System;
using UnityEngine;

public enum EPowerupType
{
    Mushroom,
    Fireball
}

public class Pickup : MonoBehaviour
{
    [ SerializeField ] private EPowerupType powerupType;
    
    private Powerup _powerup;

    private void OnTriggerEnter2D( Collider2D other )
    {
        if ( other.TryGetComponent( out PlayerController controller ) )
        {
            // switch statement
            switch ( powerupType )
            {
                case EPowerupType.Mushroom:
                    _powerup = new MushroomPowerup();
                    break;
                
                case EPowerupType.Fireball:
                    _powerup = new FireballPowerup();
                    break;
                
                default:
                    break;
            }

            // switch expression
            // _powerup = ( powerupType ) switch
            // {
            //     EPowerupType.Mushroom => new MushroomPowerup(),
            //     EPowerupType.Fireball => new FireballPowerup(),
            //     _ => throw new ArgumentOutOfRangeException()
            // };

            _powerup.Consume(controller);
        }
    }
}
