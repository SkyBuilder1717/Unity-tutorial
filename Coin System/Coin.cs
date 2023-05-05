using System.Collections;
using System.Collections.Generic;
// dont delete
using UnityEngine;

public class Coin : MonoBehaviour
{
    // On enter in box collider
    void OnTriggerEnter(Collider other)
    {
        // connection with component from script "CoinCollector"
        CoinCollector player = other.GetComponent<CoinCollector>();

        // component of script "CoinCollector" in use
        player.CoinCollect();

        // destroying coin
        Destroy(gameObject);
    }
}
