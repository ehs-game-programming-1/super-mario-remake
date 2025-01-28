using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [ SerializeField ] private TMP_Text tx_score;

    public void UpdateText( int amount )
    {
        tx_score.text = amount.ToString("000000");
    }
}
