using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControler : MonoBehaviour
{

    public Transform personaje;

    private float tamañoCamara;
    private float largoPantalla;

    // Start is called before the first frame update
    void Start()
    {
        tamañoCamara = Camera.main.orthographicSize;
        largoPantalla = tamañoCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        CalcularPosicionCamara();
    }

    void CalcularPosicionCamara()
    {
        int pantallaPersonaje = (int)(personaje.position.y / largoPantalla);

        float largoCamara = (pantallaPersonaje * largoPantalla) + tamañoCamara;

        transform.position = new Vector3(transform.position.x, largoPantalla, transform.position.z); 
    }
}
