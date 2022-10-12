using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Renderer fondo;
    public GameObject suelo;

    // Start is called before the first frame update
    void Start()
    {
        //Crear mapa
        for(int i = 0; i < 3; i++)
        {
            Instantiate(suelo, new Vector2(8 + i, -1), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.010f, 0) * Time.deltaTime;
    }
}
