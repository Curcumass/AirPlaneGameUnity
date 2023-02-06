using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private CoinCounter _coinCounter;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        _coinCounter = FindObjectOfType<CoinCounter>();

        if(other.tag == "Player")
        {
            DestroyCoin();
            _coinCounter.AddCoin();
        }
    }

    private void DestroyCoin()
    {
        Destroy(gameObject);
    }
}
