using UnityEngine;

[CreateAssetMenu(fileName = "Powerup_", menuName = "Powerups/New Fireball Powerup")]
public class FireballPowerup : Powerup
{
    [ SerializeField ] private Bullet gameObject;
    
    public override void Consume(PlayerController controller)
    {
        if (controller.IsHigherPriority(this)) return;

        controller.ActivePowerup = this;
        
        controller.BoxCollider2D.size = new Vector2( 1, 2 );
        controller.BoxCollider2D.offset = new Vector2( 0, 1 );
        
        controller.Shooting.SetObjectToSpawn(gameObject);
        controller.Shooting.enabled = true;
        
        controller.AnimationController.GetAnimator().runtimeAnimatorController = overrideController;
    }
}