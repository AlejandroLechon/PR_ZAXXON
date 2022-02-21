using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
       transform.position = playerPosition.position;

       transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y + 20, playerPosition.position.z - 25);

       
        

    }

}