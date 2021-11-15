using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    [SerializeField] float prefabSpeed;


    // Start is called before the first frame update
    void Start()
    {
        prefabSpeed = 80f;
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento dirección -z de los prefabs

        transform.Translate(Vector3.back* prefabSpeed * Time.deltaTime);

        //Destrucción de los prefabs traspasados
        float posZ = transform.position.z;

        if (posZ <= -100)
        {
            Destroy(this.gameObject);
        }
    }
   




}

