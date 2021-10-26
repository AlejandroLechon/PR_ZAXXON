using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePrefabs : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject castle;
    [SerializeField] Transform initialPosition;
    [SerializeField] Transform instantiatePosition;

    [SerializeField] float speed;

    void Start()
    {
        /*
        speed = 10f;
        castle = GameObject.Find("castle");
        //initialPosition = castle.GetComponent<Transform>();
        */

        StartCoroutine("GenerateCastle");
      
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //CORRUTINA DE INSTANCIACIÓN
    IEnumerator GenerateCastle()

    {
        while (true)
        {
            //Quaternion para girar el prefab que aparece tumbado por defecto
            castle.transform.rotation = Quaternion.AngleAxis(-90f,Vector3.right);
            


            //Instanciador de prefabs restringido
            float randomX = Random.Range(-40f, 40f);
            Vector3 newPos = new Vector3(randomX, 17.5f, instantiatePosition.position.z);
            Instantiate(castle, newPos, Quaternion.identity);

            
            yield return new WaitForSeconds(2);

        }
    }
    


}





