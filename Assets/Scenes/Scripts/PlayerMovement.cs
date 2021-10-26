using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool alive = true;
    [SerializeField] float strength;
    [SerializeField] Rigidbody dragonRigidBody;
    //Vamos a relaizar el movimiento por f�sicas por lo tanto le damos un rigidbody al Player



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerPhysicsMovement();

    }

    //Creamos este m�todo para el movimiento del player
    //Como vemos nos permitir� desplazarlo en horizontal y subirlo en vertical
    //Queremos que la ca�da no sea controlada por el jugador para que tenga que calcular:
    //la distancia, el tiempo de ca�da, y la velocidad de los prefabs.
    void playerPhysicsMovement()
    {
        float desplH = Input.GetAxis("Horizontal");
        dragonRigidBody.AddForce(Vector3.right * desplH * strength);
        dragonRigidBody = GetComponent<Rigidbody>();

        // Salto o "aleteo"
        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 4000);

        }



    }
   


}
    