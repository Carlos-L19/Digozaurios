using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject jugar;
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject enemigo;
    [SerializeField] GameObject volador;
    [SerializeField] bool time;
    [SerializeField] public float tiempo;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int mejorPuntuacion;
    [SerializeField] MoverEnemigo3 moverEnemigo3;
    [SerializeField] EnemigoCalavera enemigoCalavera;
    [SerializeField] AudioSource musicaFondo;
    // Start is called before the first frame update
    void Start()
    {

        gameOver.SetActive(false);
        jugar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (time == true)
        {
            tiempo += Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
            Debug.Log($"{minutos:D2}:{segundos:D2}");
            textoTiempo.text = $"{minutos:D2}:{segundos:D2}";
        }
    }
    public void perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        volador.SetActive(false);
        jugar.SetActive(true);
        gameOver.SetActive(true);
        time = false;
        musicaFondo.Stop();
    }
    public void ReiniciarNivel()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        volador.SetActive(true);
        moverEnemigo3.IniarEnemigo();
        enemigoCalavera.iniciarenemigo();
        jugar.SetActive(false);
        gameOver.SetActive(false);
        tiempo = 0;
        time = true;
        musicaFondo.Play();
    }


    public void SumarPuntos()
    {
        puntuacionActual++;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", mejorPuntuacion);
        }
    }
}
