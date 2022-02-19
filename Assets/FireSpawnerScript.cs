using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawnerScript : MonoBehaviour
{
    //Shooting variables
    public GameObject projectile;
    public float fireballSpeed;

    //Cooldown variables
    public float cooldownTime = 2f;
    private float nextFireTime = 0f;

    private void Update()
    {
        DispararConCooldown();

    }

    //Método de disparo con cooldown
    void DispararConCooldown()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject fireball = Instantiate(projectile, transform) as GameObject;
                Rigidbody rb = fireball.GetComponent<Rigidbody>();
                rb.velocity = transform.forward * fireballSpeed;
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
}
