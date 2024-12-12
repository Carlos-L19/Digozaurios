using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sumar_puntos : MonoBehaviour
{
    [SerializeField] TMP_Text PuntajeMaximo, PuntajeActual;
    [SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PuntajeActual.text = gameManager.puntuacionActual.ToString();
        PuntajeMaximo.text = gameManager.mejorPuntuacion.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
            gameManager.SumarPuntos();
    }
}
