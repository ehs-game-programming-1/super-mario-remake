using UnityEngine;

[CreateAssetMenu(fileName = "Powerup_", menuName = "Powerups/New Fireball Powerup")]
public class FireballPowerup : Powerup
{
    [ SerializeField ] private GameObject gameObject;
    [ SerializeField ] private AnimatorOverrideController overrideController;

    // [SerializeField] private GameObject Fireball._fireball;
    
    public override void Consume(PlayerController controller)
    {
        Debug.Log( " This is a Fireball! " );

        // if(Input.GetKeyDown(KeyCode.E))
        // GameObject.Instantiate(_fireball);    
     }

    
}