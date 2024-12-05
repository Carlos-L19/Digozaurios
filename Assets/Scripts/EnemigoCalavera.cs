using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoCalavera : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
            velocidad++;
        }
    }
    public void iniciarenemigo()
    {

    }
}
