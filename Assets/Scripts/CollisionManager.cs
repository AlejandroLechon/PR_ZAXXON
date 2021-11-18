using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public static int lives;
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public class ConfigVars : MonoBehaviour
    {
        void Die()
        {
            if (lives == 0)
            {
                Die();
            }
        }

        void OnTriggerEnter(Collider other)
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
    }
 
     
    
}