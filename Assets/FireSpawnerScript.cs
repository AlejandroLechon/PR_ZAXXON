using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawnerScript : MonoBehaviour
{
    public GameObject projectile;
    public float fireballSpeed;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject fireball = Instantiate(projectile, transform) as GameObject;
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * fireballSpeed;
        }
    }
}
