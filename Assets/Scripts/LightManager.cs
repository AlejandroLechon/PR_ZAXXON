using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField] public GameObject mydirectionalLight;
    [SerializeField, Range (0,24)] public float timeOfDay;

    // Start is called before the first frame update
    void Start()
    {
        //Este script está destinado a crear un ciclo de día y noche 
        //controlando la Transformación de mi luz principal de la escena
        
       // StartCoroutine("Hours");
        //mydirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timeOfDay * 360), -90, -170));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Hours()
    {
        for (timeOfDay = 0; timeOfDay >= 24; timeOfDay++) ;
        yield return new WaitForSeconds (4f);
    }

    void Journey()
    {
        while (true)
        {
            if (timeOfDay == 24 || timeOfDay == 0)
            {
                StartCoroutine("Hours");
            }
        }


    }
}
