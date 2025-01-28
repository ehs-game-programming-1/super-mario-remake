using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [ SerializeField ] private int amount = 1;

    private void OnTriggerEnter2D( Collider2D other )
    {
        // ScoreManager manager = other.GetComponent< ScoreManager >();
        //
        // if ( manager )
        // {
        //     manager.AddScore(amount);
        // }

        if ( other.TryGetComponent( out ScoreManager manager ) )
        {
            manager.Score.AddScore(amount);
            gameObject.SetActive(false);
        }
    }
}
