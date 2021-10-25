using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float strength;
    [SerializeField] Rigidbody dragonRigidBody;


    public bool alive = true;


    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 99f;

    }

    // Update is called once per frame
    void Update()
    {

        playerPhysicsMovement();




    }

    
    void playerPhysicsMovement()
    {
        float desplH = Input.GetAxis("Horizontal");
        dragonRigidBody.AddForce(Vector3.right * desplH * strength);
        dragonRigidBody = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 3000);

        }





    }
    /*
    //MOVIMIENTO DE LA NAVE

    void MovePlayer()
    {
        //displacement es el input; por ello hay que incluirlo como factor en el vector3

        float displacementInX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * displacementInX * movementSpeed * Time.deltaTime);

        float displacementInY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * displacementInY * movementSpeed * Time.deltaTime);

    }
    */


}
    