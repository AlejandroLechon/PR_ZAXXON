using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePrefabs : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject rock;
    [SerializeField] Transform instantiatePosition;
    [SerializeField] Transform initialPosition;


    
    [SerializeField] GameObject initObject;
    StartGame startGame;
   
    float desplX = 1.1f;
    public float countdown;
    public float speed;
    void Start()
    {
        speed = 10f;
        initialObject = GameObject.Find("StartGame");
        startGame = initObject.GetComponent<StartGame>();

        speed = startGame.speed;



        countdown = 1f;
        StartCoroutine("GenerateRocks");
      
        //CONDICIONES DE INSTANCIACIÓN DE LOS PREFABS 
        Vector3 destinationPosition = initialPosition.position;
        Vector3 despl = new Vector3(desplX, 0, 0);

        for (int n = 0; n < 8; n++)
        {

            Instantiate(rock, destinationPosition, Quaternion.identity);
            destinationPosition = destinationPosition + despl;

        }
    }
    // Update is called once per frame
    void Update()
    {
        speed = startGame.speed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    //CORRUTINA DE INSTANCIACIÓN
    IEnumerator GenerateRocks()

    {
        while (true)
        {
            float randomX = Random.Range(-40f, 40f);
            Vector3 newPos = new Vector3(randomX, instantiatePosition.position.y, instantiatePosition.position.z);
            Instantiate(rock, newPos, Quaternion.identity);

            yield return new WaitForSeconds(countdown);
        }
    }
}



