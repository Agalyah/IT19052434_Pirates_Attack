using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("SFX")]
    [SerializeField] private AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        ScoreCoin.coinAmount += 1;
        SoundManager.instance.PlaySound(coinSound);
        Destroy(gameObject);
    }

}
