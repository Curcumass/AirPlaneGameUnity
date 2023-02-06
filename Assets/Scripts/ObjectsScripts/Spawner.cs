using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private GameObject _bombPrefab;

    [SerializeField] private int _objectAmount;


    private void Start()
    {
        SpawnCoin();
    }

    private void SpawnCoin()
    {
        for(int i = 0; i < _objectAmount; i++)
        {
            Vector3 spawnPosition = new Vector3(0, Random.Range(-5f, 15f), Random.Range(-15f, 15f));

            if(Random.Range(0, 3) == 0)
            {
                Instantiate(_bombPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(_coinPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }

}
