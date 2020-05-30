using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public Vector3 V;
    Vector3 P;
    float tiempo = 0.01f;
    Color Color;
    public float Radio = 0.6f;
    float ancho, alto;

    // Start is called before the first frame update
    void Start()
    {
        ancho = 10f;
        alto = 10f;
        Color.r = Random.Range(0f, 1f);
        Color.g = Random.Range(0f, 1f);
        Color.b = Random.Range(0f, 1f);
        gameObject.GetComponent<Renderer>().material.color = Color;

    }

    // Update is called once per frame
    void Update()
    {
        P = gameObject.GetComponent<Transform>().position;
        P = P + V * tiempo;
        gameObject.GetComponent<Transform>().position = P;

       //Pared derecha
        if ((P.x + Radio) >= ancho)
        {
            V.x = -V.x;
        }
        //Pared izda
        if ((P.x - Radio) <= -ancho)
        {
            V.x = -V.x;
        }
        //Pared arriba
        if ((P.y + Radio) >= alto)
        {
            V.y = -V.y;
        }
        //Pared abajo
        if ((P.y - Radio) <= -alto)
        {
            V.y = -V.y;
        }
    }
}
