using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Vamos a realizar el movimiento por físicas por lo tanto le damos un rigidbody al Player
    [SerializeField] float strength;
    [SerializeField] Rigidbody dragonRigidBody;

    //límites de movimiento
    //public float horizontalLimit = 100f;
    public float verticalLimit = 10f;

    //variable alive
    // dato que nos viene bien saber para la gestión de prefabs, dado que dependerán de ello para existir
    public bool alive;
    public PlayerMovement playerMovement;
    [SerializeField]public int lives;

    public float dragonSpeed = 0.5f;
    



    // Start is called before the first frame update
    void Start()
    {
        //Le damos el valor true a alive, comienza el juego
        alive = true;
        lives = 3;
       // for (float dragonSpeed = 0; dragonSpeed < 10; dragonSpeed += 0.0000001f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (alive == true)
        {
            playerPhysicsMovement();
            dragonSpeed += 0.000001f;

        }
    }

    //Creamos este método para el movimiento del player
    //Como vemos nos permitirá desplazarlo en horizontal y subirlo en vertical
    //Queremos que la caída no sea controlada por el jugador para que tenga que calcular:
    //la distancia, el tiempo de caída, y la velocidad a la que se le aproximan los prefabs.
    void playerPhysicsMovement()
    {

        //Movimiento físico

        float desplH = Input.GetAxis("Horizontal");
       
        //movimiento lateral según fuerzas
        dragonRigidBody.AddForce(Vector3.right * desplH * strength* dragonSpeed);
        dragonRigidBody = GetComponent<Rigidbody>();
            
        //movimiento vertical restingido y según fuerzas 
       
        if ((transform.position.y >= -verticalLimit ) && (transform.position.y <= verticalLimit))

            // Salto o "aleteo"
            if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 3000);

        }
     

    }
    



    /*
    //Método para que muera la nave
    void Die()
    {
        if(ConfigVars.numLives == 0)
        {
            Die();
        }
    }
    */
    /*
       if ((transform.position.x >= -horizontalLimit) && (transform.position.x <= horizontalLimit))
       {
           //movimiento lateral según fuerzas
           dragonRigidBody.AddForce(Vector3.right * desplH * strength);
           dragonRigidBody = GetComponent<Rigidbody>();
       }
       */
    //de alguna manera esta condición debe resolver que se corrija el movimiento si se detecta un valor válido
    //quizás podemos hacer que al pasar el límite se nos empuje hacia el origen
    //no se produce el impulso, creo que es porque no detecta nunca que llegue al límite
    /*
    if ((transform.position.x <= -horizontalLimit) && (transform.position.x >= horizontalLimit))
    {
        dragonRigidBody.AddForce(Vector3.right * desplH * strength * 4000);
        dragonRigidBody = GetComponent<Rigidbody>();

    }
    */
}
