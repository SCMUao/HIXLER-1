using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVIda : MonoBehaviour
{

    private Slider slider;
    [SerializeField] private float vida;

    private MovimientoJugador movimientoJugador;
    [SerializeField] private float tiempoPerdidaControl;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        movimientoJugador = GetComponent<MovimientoJugador>();
        animator = GetComponent<animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    } 

    public void CambiarVidaActual(float cantidadVida)
    {
        slider.value = cantidadVida;
    }

    public void InicializarBarraDeVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
    }

    public void TomarDaño(float daño, Vector2 posicion)
    {
        vida -= daño;
        animator.SetTrigger("Golpe");
        StartCorountine(PerderControl());
        movimientoJugador.Rebote(posicion);
    }

    private IEnumerator PerderControl()
    {
        movimientoJugador.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        movimientoJugador.sePuedeMover = true;
    }
}
