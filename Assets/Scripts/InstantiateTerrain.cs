using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTerrain : MonoBehaviour
{
    [SerializeField] GameObject Land;
    [SerializeField] Transform initialPosition;
    [SerializeField] Transform instantiatePosition;
    public float terrainScale = 0.68f;

    public bool alive;
    private PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {

       Instantiate(Land);


        //StartCoroutine("InstantiateLand");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InstantiateLand()

    {
        while (alive == true)
        {

            // Instanciador de terreno 

            //Instantiate(Land, new Vector3(0f, 0f, -1 * Time.deltaTime * landSpeed* terrainScale), Quaternion.identity);
            Instantiate(Land, new Vector3(0f, 0f, 0f), Quaternion.identity);

            //Movimiento dirección -z del terreno
            //transform.Translate(Vector3.back * Time.deltaTime * landSpeed);

            //Destrucción de los terrenos traspasados
            float posZ = transform.position.z;

            if (posZ <= -100)
            {
                Destroy(this.gameObject);
            }

            //retorno de la corrutina
            
             yield return new WaitForSeconds(2f);

           
        }
    }

}






