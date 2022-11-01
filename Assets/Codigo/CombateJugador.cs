using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{

    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraVida barraDeVida;

    private PlayerController movimientoJugador;
    [SerializeField] private float tiempoPerdidaControl;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        movimientoJugador = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();

        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        barraDeVida.CambiarVidaActual(vida);

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TomarDaño(float daño, Vector2 posicion)
    {
        vida -= daño;
        animator.SetTrigger("Golpe");
        StartCoroutine(PerderControl());

        //perder control
        movimientoJugador.Rebote(posicion);
    }

    private IEnumerator PerderControl()
    {
        movimientoJugador.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        movimientoJugador.sePuedeMover = true;
    }

    public void Curar(float curacion)
    {
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }

        else
        {
            vida += curacion;
        }
    }
}
