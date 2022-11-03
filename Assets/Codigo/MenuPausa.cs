using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject menuPausa;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausa();
        }
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);

    }


    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);

    }


    public void Ajustes()
    {

    }


    public void Guardar()
    {

    }


    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void Home()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Salir()
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }
}
