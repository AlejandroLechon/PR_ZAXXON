using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    public static int lives;
    [SerializeField] GameObject Player;
    private PlayerMovement playerMovement;

    //sprites vidas
    [SerializeField] Image livesImage;
    [SerializeField] Sprite[] livesSprite;



    // Start is called before the first frame update
    void Start()
    {
      
      int lives = GameManager.lives;
     
      //Con esta línea tenemos las vidas asociadas con los sprites
      livesImage.sprite = livesSprite[lives];
      
      print(lives);

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
                    GameManager.lives--;
                    
                }
                print(lives);
               
            }

        }
    }
 
     
    
}