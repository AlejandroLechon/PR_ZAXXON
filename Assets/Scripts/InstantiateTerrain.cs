using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTerrain : MonoBehaviour
{
    //Variable Gameobject 
    [SerializeField] GameObject Land;




    // Start is called before the first frame update
    void Start()
    {
        //Una única instanciación dado que nuestro 
        //escenario no tiene movimiento
       Instantiate(Land, new Vector3(0f, 0f, 0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}






