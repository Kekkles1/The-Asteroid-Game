using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.isKinematic = true;

        rb.velocity = firePoint.transform.right * bulletForce;
        // rb.AddForce(firePoint.right * bulletForce,ForceMode2D.Impulse);

    }
}
