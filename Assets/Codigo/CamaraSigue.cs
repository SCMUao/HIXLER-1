using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSigue : MonoBehaviour
{

    public Transform objetivo;
    public float suavizado = 2f;

    Vector3 desface;
    // Start is called before the first frame update
    void Start()
    {
        desface = transform.position - objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 posicionObjetivo = objetivo.position + desface;
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavizado*Time.deltaTime);
    }
}
