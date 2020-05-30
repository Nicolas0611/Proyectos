using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Demo : MonoBehaviour
{
    public float masa, magnitud;

    public Vector3 Fuerza;
    float r, Iner;
    Vector3 aceleracion;
    Vector3 tor;
    Vector3 posicionAngular, unitario;
    Vector3 angular;
    Vector3 w;
    float tiempo;
    Quaternion quaternion;
    //GameObject Arrastrar;
    float distance = 10;

    void Start()
    {
        w.x = 0;
        w.y = 0;
        w.z = 0;
        tiempo = 0.01f;
        r = 10f;
      //  Arrastrar = GameObject.Find("ball");
    }


    void Update()
    {
        posicionAngular = gameObject.GetComponent<Transform>().rotation.eulerAngles;
       // Fuerza = Arrastrar.GetComponent<Fuerza>().fuerza;
        magnitud = Fuerza.magnitude;
        unitario = Fuerza.normalized;
        Fuerza.y = magnitud * unitario.y;
        tor = Fuerza * r;
        Iner = (masa * Mathf.Pow(r, 2)) / 3;
        angular = tor / Iner;
        w = w + angular * tiempo;
        posicionAngular = posicionAngular + w * tiempo;
        quaternion = Quaternion.Euler(posicionAngular.x, posicionAngular.y, posicionAngular.z);
        gameObject.GetComponent<Transform>().rotation = quaternion;
    }
}
