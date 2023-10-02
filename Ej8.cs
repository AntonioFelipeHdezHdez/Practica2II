using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{
    GameObject[] Grupo2;
    GameObject cubo;
    List<float> distancias;
    bool aumento = true;

    // Start is called before the first frame update
    void Start()
    {
        Grupo2 = GameObject.FindGameObjectsWithTag("Grupo2");
        cubo = GameObject.FindWithTag("Cube");
        distancias = new List<float>();  // Hay que inicializar la lista
    }

    // Update is called once per frame
    void Update()
    {
        distancias.Clear();  // Hay que limpiar la lista

        float distancia = Vector3.Distance(Grupo2[0].transform.position, cubo.transform.position);
        distancias.Add(distancia);

        distancia = Vector3.Distance(Grupo2[1].transform.position, cubo.transform.position);
        distancias.Add(distancia);

        distancia = Vector3.Distance(Grupo2[2].transform.position, cubo.transform.position);
        distancias.Add(distancia);

        // Subir en altura la esfera más cercana
        float distanciaMinima = distancias[0];
        int indiceCercano = 0;
        for (int i = 0; i < distancias.Count; i++) {
            if (distancias[i] < distanciaMinima) {
                distanciaMinima = distancias[i];
                indiceCercano = i;
            }
        }
        
        if (aumento == true)
          Grupo2[indiceCercano].transform.position += new Vector3(0, 1, 0);
        aumento = false;

        // Cambiar el color de la esfera más lejana cuando se presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))  {
            float distanciaMaxima = distancias[0];
            int indiceLejano = 0;
            for (int i = 0; i < distancias.Count; i++) {
                if (distancias[i] > distanciaMaxima) {
                    distanciaMaxima = distancias[i];
                    indiceLejano = i;
                }
            }
            Grupo2[indiceLejano].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
