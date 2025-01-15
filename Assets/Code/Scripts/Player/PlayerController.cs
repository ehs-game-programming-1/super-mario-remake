using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [ field: SerializeField ] public Movement Movement { get; private set; }
    [ field: SerializeField ] public MovementAnimationController AnimationController { get; private set; }
    [ field: SerializeField ] public ScoreManager ScoreManager { get; private set; }
}
