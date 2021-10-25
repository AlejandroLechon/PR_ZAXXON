using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTerrain : MonoBehaviour
{
    [SerializeField] GameObject Land;


    // Start is called before the first frame update
    void Start()
    {
        InstantiateLand();

    }

    // Update is called once per frame
    void Update()
    {


    }
    void InstantiateLand()
    {
        Instantiate(Land);
    }
}



