using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private GameObject _dieEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<BiPlaneHealth>(out BiPlaneHealth _health))
        {
            _health.TakeDamage(_damage);
            DestroyBomb();
        }
    }


    private void DestroyBomb()
    {
        Instantiate(_dieEffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
