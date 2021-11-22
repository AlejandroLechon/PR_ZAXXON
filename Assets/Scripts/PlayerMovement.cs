using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Vidas
    
    // public static int lives;

    //Rigidbody al Player.Movimiento por f�sicas.
    [SerializeField] float strength;
    [SerializeField] Rigidbody dragonRigidBody;

    //l�mites de movimiento vertical
    public float verticalLimit = 30f;

    //variable alive

    public PlayerMovement playerMovement;

    //Velocidad
    public float dragonSpeed = 0.2f;



    // Start is called before the first frame update
    void Start()
    {
       //Le damos el valor true a alive, comienza el juego

       GameManager.alive = true;

       // GameManager.lives = 3;

       print("Tercero");

    }

    // Update is called once per frame
    void Update()
    {
        
        //Solo si estoy vivo, deja que me mueva.
        if (GameManager.alive == true)
        {
            playerPhysicsMovement();
            dragonSpeed += 0.00001f;

        }
    }
    //PLAYER PHYSICS MOVEMENT
    //Creamos este m�todo para el movimiento del player
    //Como vemos nos permitir� desplazarlo en horizontal y subirlo en vertical
    //Queremos que la ca�da no sea controlada por el jugador para que tenga que calcular:
    //la distancia, el tiempo de ca�da, y la velocidad a la que se le aproximan los prefabs.
    void playerPhysicsMovement()
    {

        //Movimiento f�sico

        float desplH = Input.GetAxis("Horizontal");
       
        //movimiento lateral seg�n fuerzas
        dragonRigidBody.AddForce(Vector3.right * desplH * strength* dragonSpeed);
        dragonRigidBody = GetComponent<Rigidbody>();

            
        //movimiento vertical restingido y seg�n fuerzas 
        if ((transform.position.y >= -verticalLimit ) && (transform.position.y <= verticalLimit))


        // Salto o "aleteo"
        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 3000);

        }
     

    }


}
