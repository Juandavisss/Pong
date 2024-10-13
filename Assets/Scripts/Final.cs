using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public GameManager GameManager;
    public Button reinicio;
    public Button salir;
    public TextMeshProUGUI ganador;
    // Start is called before the first frame update
    void Start()
    {
        reinicio.onClick.AddListener(Jugar);
        salir.onClick.AddListener(Salir);
        ganador.text = GameManager.GetGanador();
    }

    public void Jugar()
    {
        GameObject gamemanager = GameObject.Find("GameManager");//obtener el gamemanager
        if (gamemanager != null)//si gamemnager es distitno a null te lo destruye
        {
            Destroy(GameManager);
            
        }
        SceneManager.LoadScene("Jugar");
    }
    public void Salir()
    {
        Application.Quit();
        //te cierra la aplicacion completamente
    }
  
}
