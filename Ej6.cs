using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6 : MonoBehaviour
{
    GameObject cilindro;
    GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cylinder");
        cubo = GameObject.FindWithTag("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        // Poner el cilindro 5 unidades en el eje x a la derecha sobre el propio objeto
        cilindro.transform.position = new Vector3(transform.position.x + 5, cilindro.transform.position.y, cilindro.transform.position.z);
        // Poner el cubo 5 unidades en el eje x a la izquierda sobre el propio objeto
        cubo.transform.position = new Vector3(transform.position.x - 5, cubo.transform.position.y, cubo.transform.position.z);
    }
}
