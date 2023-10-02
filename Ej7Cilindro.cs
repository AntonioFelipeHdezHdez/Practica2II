using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7Cilindro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            // cambiara un color aleatorio
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
