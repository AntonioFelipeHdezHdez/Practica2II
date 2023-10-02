using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] private int[] numeros = new int[8];
    public int min = 0;
    public int max = 25;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++) {
            numeros[i] = Random.Range(min, max);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Elegir un numero aleatorio de un array
        numeros[Random.Range(0, numeros.Length)] = Random.Range(min, max);
        for (int i = 0; i < numeros.Length; i++) {
            if (numeros[i] > 15) {
                Debug.Log(numeros[i]);
            }
        }
    }
}
