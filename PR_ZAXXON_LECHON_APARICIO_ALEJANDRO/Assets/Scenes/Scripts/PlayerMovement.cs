using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;






    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 20f;





    }

    // Update is called once per frame
    void Update()
    {




        /*
        //RESTRICCIÓN DE MOVIMIENTO HORIZONTAL
        //store the transform.position of your car in a new Vector3, i called it "pos"
        Vector3 pos = transform.position;

        //then access the x value and clamp it
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);

        //and don't forget to turn the new "pos" into the transform.position of your car
        transform.position = pos;
        */

    }
    void MovePlayer()
    {
        //MOVIMIENTO DE LA NAVE

        //displacement es el input; por ello hay que incluirlo como factor en el vector3

        float displacementInX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * displacementInX * movementSpeed * Time.deltaTime);

        float displacementInY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * displacementInY * movementSpeed * Time.deltaTime);

    }
}
    