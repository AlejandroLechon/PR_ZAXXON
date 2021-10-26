using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    [SerializeField] float prefabSpeed;
    [SerializeField] GameObject castle;

    // Start is called before the first frame update
    void Start()
    {
        prefabSpeed = 90f;
        StartCoroutine("destroyPrefabs");

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento dirección -z de los prefabs

        transform.Translate(Vector3.back* prefabSpeed * Time.deltaTime);

    }
    IEnumerator destroyPrefabs()
    {
        //destrucción de prefabs traspasados
        if (castle.transform.position.z <= -1)
        {
            Destroy(castle);
        }
        yield return new WaitForSeconds(1);

    }




}

