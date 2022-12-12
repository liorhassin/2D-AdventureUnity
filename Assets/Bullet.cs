using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float damage;
    public GameObject impactEffect; //Save to when bullet impact effect is created.
    // Start is called before the first frame update
    private void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 3f); // Bullet lifespan in seconds
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            return;
        }
        Enemy enemy = col.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        //Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
