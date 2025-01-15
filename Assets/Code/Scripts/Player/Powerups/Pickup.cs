using UnityEngine;

#region Old Code

public enum EPowerupType
{
    Mushroom,
    Fireball
}

#endregion

public class Pickup : MonoBehaviour
{
    #region Old Code

    //[ SerializeField ] private EPowerupType powerupType;

    #endregion
    
    [SerializeField] private Powerup powerup;

    private void OnTriggerEnter2D( Collider2D other )
    {
        if ( other.TryGetComponent( out PlayerController controller ) )
        {
            #region Old Code

            // switch statement
            // switch ( powerupType )
            // {
            //     case EPowerupType.Mushroom:
            //         _powerup = new MushroomPowerup();
            //         break;
            //     
            //     case EPowerupType.Fireball:
            //         _powerup = new FireballPowerup();
            //         break;
            //     
            //     default:
            //         break;
            // }

            // switch expression
            // _powerup = ( powerupType ) switch
            // {
            //     EPowerupType.Mushroom => new MushroomPowerup(),
            //     EPowerupType.Fireball => new FireballPowerup(),
            //     _ => throw new ArgumentOutOfRangeException()
            // };

            #endregion

            if ( powerup != null )
            {
                powerup.Consume(controller);
            }
        }
    }
}
