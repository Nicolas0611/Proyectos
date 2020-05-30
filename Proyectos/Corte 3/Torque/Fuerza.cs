using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour
{
    Vector3 posicionInicial, posicionFinal;
    public Vector3 fuerza;
    //Se obtiene una distancia (De la camara la posicion de arrastre)
    float distance = 20;
    void Start() {
        // Posicion Inicial del Objeto
        posicionInicial = gameObject.GetComponent<Transform>().position;
    
    }
    void OnMouseDrag()
    {
        // La posicion del mouse.
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        // La posicion del Objeto.
        Vector3 ObjPosition = Camera.main.ScreenToWorldPoint(mousePosition);       
        transform.position = ObjPosition;
    }

    void OnMouseUp() 
    { 
        
        posicionFinal = gameObject.GetComponent<Transform>().position;
        // Se calcula el vector fuerza Donde se coje la posicion final y la posicion inicial
        fuerza = posicionFinal - posicionInicial;
    }
}
