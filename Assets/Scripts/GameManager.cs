using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject jugar;
    [SerializeField] GameObject exit;
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject enemigo;
    [SerializeField] bool time;
    [SerializeField] public float tiempo;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] int puntuacionActual;
    [SerializeField] int mejorPuntuacion;
    // Start is called before the first frame update
    void Start()
    {

        gameOver.SetActive(false);
        jugar.SetActive(false);
        exit.SetActive(false);

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
            textoTiempo.text = $"{minutos: D2}:{segundos: D2}";
        }
    }
    public void perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        jugar.SetActive(true);
        exit.SetActive(true);
        gameOver.SetActive(true);
        time = false;
    }
    public void ReiniciarNivel()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        jugar.SetActive(false);
        exit.SetActive(false);
        gameOver.SetActive(false);
        tiempo = 0;
        time = true;
    }

    

}
