using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    private bool _canFire;
    private float _timer;


    private void Start()
    {
        _canFire = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_canFire)
        {
            _timer += Time.deltaTime;
            if(_timer>=fireRate)
            {
                _canFire = true;
                _timer = 0;
            }
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            _canFire = false;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
