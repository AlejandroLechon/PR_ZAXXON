using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    
    
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
       //alive = true;
      // PlayerMovement.lives = 3;
    }

    // Update is called once per frame
    void Update()
    {

    
    }
    /*
    void Die()
    {
        if (lives == 0)
        {
            Die();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        {
            print(PlayerMovement.lives);
            print(other.tag);
            if (other.tag == "Prefab")
            {
                lives--;
            }
            print(lives);
        }

    }
    */
}