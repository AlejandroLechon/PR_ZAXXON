using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePrefabs : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] Transform initialPosition;


    //array de prefabs
    [SerializeField] public GameObject[] scenePrefabs;
    [SerializeField] float speed;

    void Start()
    {
       StartCoroutine("GenerateAllPrefabs");


    }
    // Update is called once per frame
    void Update()
    {

        //Destrucción de los prefabs traspasados
        float posZ = transform.position.z;

        if (posZ <= -100)
        {
            Destroy(this.gameObject);
        }
    }
    //CORRUTINA DE INSTANCIACIÓN
    IEnumerator GenerateAllPrefabs()

    {
        while (true)
        {
            

            //Instanciador de prefabs restringido
            float randomX = Random.Range(-80f, 80f);

            //instanciación aleatoria de prefabs por array 
            int randomNumber = Random.Range(0, scenePrefabs.Length);

            Vector3 newPos = new Vector3(randomX, 0, 500);
            
            Instantiate(scenePrefabs[randomNumber], newPos, Quaternion.identity);

            yield return new WaitForSeconds(0.6f);
           
           
        }
    }
    

}





