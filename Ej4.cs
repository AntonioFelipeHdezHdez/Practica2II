using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* Forma facil
        Vector3 posicion = transform.position;
        Debug.Log("La posicion de la esfera es: " + posicion);       
        */
        Transform miTransform = GetComponent<Transform>();
        Vector3 posicion = miTransform.position;
        Debug.Log("La posición de la esfera es: " + posicion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
