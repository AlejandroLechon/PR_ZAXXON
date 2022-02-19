using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartFireball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Destroy(gameObject);

    }
}
