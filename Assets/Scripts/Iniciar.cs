using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Iniciar : MonoBehaviour
{
    public Button botonJugar;
    // Start is called before the first frame update
    void Start()
    {
        botonJugar.onClick.AddListener(Jugar);//AL BOTON DE JUGAR, CUANDO LE DAMOS CLIC SE EJECUTA EL METODO JUGAR 
    }

    // Update is called once per frame
    public void Jugar()
    {
        SceneManager.LoadScene("Jugar");//ESTO MANEJA LAS ESCENAS Y CARGA LA SIGUIETNE ESCENA
    }
}
