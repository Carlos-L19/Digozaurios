using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual;
    [SerializeField] TMP_Text mejorPuntuacion;
    [SerializeField] GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         puntuacionActual.text = instance.puntuacionActual.ToString();
        mejorPuntuacion.text = instance.mejorPuntuacion.ToString();
    }
}
