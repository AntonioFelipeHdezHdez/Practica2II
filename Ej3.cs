using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{
    public Vector3 vector = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vector2 = new Vector3(1.0f, 2.0f, 3.0f);
    [SerializeField] private float magnitud1;
    [SerializeField] private float magnitud2;
    [SerializeField] private float angulo;
    [SerializeField] private float distancia;
    [SerializeField] private string mensaje;
    // Start is called before the first frame update
    void Start()
    {
        // Magnitud
        magnitud1 = vector.magnitude;
        magnitud2 = vector2.magnitude;
        Debug.Log("Magnitud del vector 1: " + vector.magnitude);
        Debug.Log("Magnitud del vector 2: " + vector2.magnitude);
        // Angulo que forman entre sí
        angulo = Vector3.Angle(vector, vector2);
        Debug.Log("Angulo entre los vectores: " + Vector3.Angle(vector, vector2));
        // Distancia entre ambos
        distancia = Vector3.Distance(vector, vector2);
        Debug.Log("Distancia entre los vectores: " + Vector3.Distance(vector, vector2));
        // Mensaje que indica que vector esta mas alto
        mensaje = "El vector 1 esta mas alto";
        if (vector.y > vector2.y)
        {
            Debug.Log("El vector 1 esta mas alto");
        }
        else
        {
            Debug.Log("El vector 2 esta mas alto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
