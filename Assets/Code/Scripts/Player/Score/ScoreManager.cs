using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [ SerializeField ] private ScoreUI ui;
    [ field: SerializeField ] public Score Score { get; private set; }

    private void Awake() => Score = new Score();

    private void OnEnable() => Score.OnScoreChanged += ui.UpdateText;
    private void OnDisable() => Score.OnScoreChanged -= ui.UpdateText;
}

[System.Serializable]
public class Score
{
    [SerializeField] private int currentScore = 0;

    public event Action< int > OnScoreChanged;
    
    public void AddScore( int count )
    {
        currentScore += count;
        
        OnScoreChanged?.Invoke(currentScore);
    }
}
