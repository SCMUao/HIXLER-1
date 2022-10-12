using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBola : MonoBehaviour
{

    public float speed;
    public bool esDerecha;

    public float contadorTiempo;
    public float TiempoCambio;

    // Start is called before the first frame update
    void Start()
    {
        contadorTiempo = TiempoCambio;
    }

    // Update is called once per frame
    void Update()
    {
        if(esDerecha == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (esDerecha == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        contadorTiempo -= Time.deltaTime;

        if(contadorTiempo <= 0)
        {
            contadorTiempo = TiempoCambio;
            esDerecha = !esDerecha;
        }
    }
}
