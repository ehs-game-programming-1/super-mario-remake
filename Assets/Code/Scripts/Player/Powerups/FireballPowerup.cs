using UnityEngine;

[CreateAssetMenu(fileName = "Powerup_", menuName = "Powerups/New Fireball Powerup")]
public class FireballPowerup : Powerup
{
    
    [SerializeField] private AnimatorOverrideController overrideController;
    [SerializeField] private GameObject Muzzle;

    public override void Consume(PlayerController controller)
    {
        //controller.BoxCollider2D.size = new  Vector2(1, 1);
        //controller.BoxCollider2D.offset = new Vector2(0, 1);

        controller.AnimationController.GetAnimator().runtimeAnimatorController = overrideController;



        //Debug.Log( " This is a Fireball! " );
    }
}