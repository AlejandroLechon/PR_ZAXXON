using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    [SerializeField] Transform initialPosition;

    private Vector3 intialPosition = new Vector3(0f, 8f, 0f);

    

    

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 20f;
        transform.position = intialPosition;
        

    }

    // Update is called once per frame
    void Update()
    {
       
        //RESTRICCIÓN DE MOVIMIENTO HORIZONTAL
        //store the transform.position of your car in a new Vector3, i called it "pos"
        Vector3 movementInX = transform.position;

        //then access the x value and clamp it
        movementInX.x = Mathf.Clamp(movementInX.x, -60, 60);

        //and don't forget to turn the new "pos" into the transform.position of your car
        transform.position = movementInX;

        //RESTRICCIÓN DE MOVIMIENTO VERTICAL
    
        Vector3 movementInY = transform.position;
        movementInY.y = Mathf.Clamp(movementInY.y, 2, 20);
        transform.position = movementInY;

        
        //MOVIMIENTO DEL PLAYER

        void MovePlayer()
        {
          

            //displacement es el input; por ello hay que incluirlo como factor en el vector3

            float displacementInX = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * displacementInX * movementSpeed * Time.deltaTime);

            float displacementInY = Input.GetAxis("Vertical");
            transform.Translate(Vector3.up * displacementInY * movementSpeed * Time.deltaTime);

        }
        MovePlayer();
    }
   
}

    