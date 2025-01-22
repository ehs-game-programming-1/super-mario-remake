using UnityEngine;

[CreateAssetMenu(fileName = "Powerup_", menuName = "Powerups/New Small Powerup")]
public class SmallPowerup : Powerup
{
    public override void Consume( PlayerController controller )
    {
        if (controller.IsHigherPriority(this)) return;
        
        controller.ActivePowerup = this;
        
        controller.BoxCollider2D.size = new Vector2( 1, 1 );
        controller.BoxCollider2D.offset = new Vector2( 0, 0.5f );
        
        controller.AnimationController.GetAnimator().runtimeAnimatorController = overrideController;
    }
}
