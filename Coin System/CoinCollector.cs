using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // creating new variable
    private int coinCount = 0;
    // import Audio Source
    public AudioSource audiosource;
    // import sound
    public AudioClip CollectSound;

    public void CoinCollect()
    {
        // import variable "coinCount"
        coinCount++;
   
        // playing sound
        audiosource.PlayOneShot(CollectSound);

        // coin count in console
        print("Монеты: " + coinCount);
    }
}
