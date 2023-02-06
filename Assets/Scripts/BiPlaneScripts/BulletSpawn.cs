using UnityEngine;


public class BulletSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletSpeed;

    [SerializeField] private float _timeToShoot = 0.3f;

    [SerializeField] private AudioSource _shotSound;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            if(_timer > _timeToShoot)
            {
                CreateBullet();
                _timer = 0; 
            }
        }
    }

    private void CreateBullet()
    {
        GameObject bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletSpeed;

        _shotSound.pitch = Random.Range(0.7f, 1.3f);
        _shotSound.Play();
    }

}
