using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    //Variables del Player
    public static int lives; // Contador vidas

    [SerializeField] GameObject Player;

    //sprites vidas
    [SerializeField] Image livesImage;
    [SerializeField] Sprite[] livesSprite;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3; // Igualamos las vidas a 3.

        livesImage = GameObject.Find("LivesImage").GetComponent<Image>(); // Cogemos el valor de la imagen y le decimos que es el objeto LivesImage,
        //dentro del cual cogemos el componente Image.

      
      
      print(lives);
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Prefab") // Si me choco con un prefab, quítame una vida.
        {
            lives--; // Restamos una vida.
            livesImage.sprite = livesSprite[lives]; // Cambiamos el valor de la imagen a lo que valga las vidas.
            print(lives);
        }
    }

    public void Die() // METODO DIE>>START
    {
        if (lives <= 0) //si mis vidas llegan a 0, llévame a start
        {
            SceneManager.LoadScene(0);
        }
    }


 
     
    
}