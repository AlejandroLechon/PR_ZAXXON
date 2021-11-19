using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Vidas
    
    public static int lives;

    //Rigidbody al Player.Movimiento por físicas.
    [SerializeField] float strength;
    [SerializeField] Rigidbody dragonRigidBody;

    //límites de movimiento vertical
    public float verticalLimit = 30f;

    //variable alive
    // dato que nos viene bien saber para la gestión de prefabs, 
    // ya que dependerán de ello para existir.

    public static bool alive;
    public PlayerMovement playerMovement;

    //Velocidad
    public float dragonSpeed = 0.2f;
    



    // Start is called before the first frame update
    void Start()
    {
        //Le damos el valor true a alive, comienza el juego
        alive = true;
        GameManager.lives = 3;

        print(GameManager.lives);

       
    }

    // Update is called once per frame
    void Update()
    {
        
        //Solo si estoy vivo, déjame moverme.
        if (alive == true)
        {
            playerPhysicsMovement();
            dragonSpeed += 0.00001f;

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

    //Método para que muera la nave
    void Die()
    {
        if(lives == 0)
        {
            alive = false;
            Destroy(this.gameObject,3f);
        }
    }
    

}
