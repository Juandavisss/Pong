using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI puntos1;
    public TextMeshProUGUI puntos2;
    private int puntosjugador1 = 0;
    private int puntosjugador2 = 0;
    private int puntosVictoria = 3;
    private string nombreGanador;
    
    public void PuntosJugador1()
    {
        puntosjugador1++;
        puntos1.text = puntosjugador1.ToString();
        if(puntosjugador1 == puntosVictoria)
            /**
            {
                SetGanador("Ju1");
                SceneManager.LoadScene("Final");//ESTO MANEJA LAS ESCENAS Y CARGA LA SIGUIETNE ESCENA
            }
            */
            if (puntosjugador1 >= puntosVictoria)
            {
                Debug.Log("Jugador 1 ha ganado");
                SetGanador("J1");
                SceneManager.LoadScene("Final");
            }
            /*
            else if (puntosjugador2 >= puntosVictoria)
            {
                Debug.Log("Jugador 2 ha ganado");
                SetGanador("J2");
                SceneManager.LoadScene("Final");
            }
            */

    }

    public void PuntosJugador2()
    {
        puntosjugador2++;
        puntos2.text = puntosjugador2.ToString();
        if (puntosjugador2 >= puntosVictoria)
        {
            SetGanador("Ju2");
            SceneManager.LoadScene("Final");//ESTO MANEJA LAS ESCENAS Y CARGA LA SIGUIETNE ESCENA
        }
        /*
        else if (puntosjugador1 >= puntosVictoria)
        {
            Debug.Log("Jugador 1 ha ganado");
            SetGanador("J1");
            SceneManager.LoadScene("Final");
        }
        */
    }

    public void SetGanador(string nombreGanador)
    {
        this.nombreGanador=nombreGanador;
        

    }

    public string GetGanador()
    {
        this.nombreGanador = nombreGanador;
        return this.nombreGanador;
    }


}
