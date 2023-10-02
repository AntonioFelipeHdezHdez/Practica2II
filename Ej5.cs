using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cilindro = GameObject.FindWithTag("Cylinder");
        GameObject cubo = GameObject.FindWithTag("Cube");
        // Distancia entre el cilindro y el cubo
        float distancia = Vector3.Distance(cilindro.transform.position, cubo.transform.position);
        Debug.Log("Distancia entre el cilindro y el cubo: " + distancia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
