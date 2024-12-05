using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemigo3 : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] Vector2 posicionMinima;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionInicial = transform.position;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial; 
           if (velocidad < 30)
            {
                velocidad++;
            }
        }
       
    }
    public void IniarEnemigo ()
    {
        transform.position = posicionInicial;
        velocidad = 10;
    }
}
