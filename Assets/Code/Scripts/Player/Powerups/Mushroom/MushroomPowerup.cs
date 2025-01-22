using UnityEngine;

[CreateAssetMenu(fileName = "Powerup_", menuName = "Powerups/New Mushroom Powerup")]
public class MushroomPowerup : Powerup
{
    public override void Consume(PlayerController controller)
    {
        if (controller.IsHigherPriority(this)) return;
        
        controller.ActivePowerup = this;
        
        controller.BoxCollider2D.size = new Vector2( 1, 2 );
        controller.BoxCollider2D.offset = new Vector2( 0, 1 );
        
        controller.AnimationController.GetAnimator().runtimeAnimatorController = overrideController;
    }
}