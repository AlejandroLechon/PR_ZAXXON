using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePrefabs : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject castle;
    [SerializeField] Transform initialPosition;
    [SerializeField] float speed;
    Vector3 destinationPosition;

    void Start()
    {
        speed = 10f;
        castle = GameObject.Find("Castle");
        initialPosition = castle.GetComponent<castle>();



        /*
        for (int n = 0; n < 10; n++)
        {
            int y = 0;
            Vector3 changePosition = new Vector3(y, 0f, 0f);
            destinationPosition = initialPosition.position + changePosition;  
            Instantiate(castle, destinationPosition, Quaternion.identity);
            y += 2;

        }
        /*
        StartCoroutine("GenerateCastle");
      
        //CONDICIONES DE INSTANCIACIÓN DE LOS PREFABS 
        Vector3 destinationPosition = initialPosition.position;
        Vector3 despl = new Vector3(desplX, 0, 0);

        for (int n = 0; n < 8; n++)
        {

            Instantiate(castle, destinationPosition, Quaternion.identity);
            destinationPosition = destinationPosition + despl;

        }
        */
    }
    // Update is called once per frame
    void Update()
    {
      //speed = castle.speed;
      transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
    /*
    //CORRUTINA DE INSTANCIACIÓN
    IEnumerator Generate()

    {
        while (true)
        {
            float randomX = Random.Range(-40f, 40f);
            Vector3 newPos = new Vector3(randomX, instantiatePosition.position.y, instantiatePosition.position.z);
            Instantiate(castle, newPos, Quaternion.identity);

            yield return new WaitForSeconds(countdown);
        }
    }
    */


}





