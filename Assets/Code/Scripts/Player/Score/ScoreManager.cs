using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [ SerializeField ] private ScoreUI ui;
    [ SerializeField ] private int score;

    public void AddScore( int count )
    {
        score += count;
        ui.UpdateText(score);
    }
}
