using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPerro : MonoBehaviour
{
    /* Si el gato se acerca al perro 
    entonces se mostrará el mensaje de interaccion
    Clickear para mostrar mensajes
    */

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeTieneHambre;
    public Image mensajeExigente;
    public Image mensajeAgradecimiento;
    public Image mensajeReflexivo;

    public Image mensajeInteraccion;
    public GameObject recompensaMaisha;

    public bool tieneHambre = true;
    public bool estaExigente = false;
    public bool estaAgradecido = false;
    public bool estaReflexivo = false;

    public bool clicIzquierdo = false;

    public ComportamientoRefri compRefri;
    public ComportamientoEstufa compEstufa;

    void Start()
    {
        mensajeTieneHambre.enabled = false;
        mensajeExigente.enabled = false;
        mensajeReflexivo.enabled = false;
        mensajeAgradecimiento.enabled = false;
        mensajeInteraccion.enabled = false;
        recompensaMaisha.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            mensajeInteraccion.enabled = false;

            // A partir de aqui se van revisando las diferentes situaciones de interaccion con el canino
            if(tieneHambre == true)
            {
                mensajeTieneHambre.enabled = true;
            }
            if (tieneHambre == true && compRefri.contarConCarne == true) 
            {
                mensajeExigente.enabled = true;
                estaExigente = true;
            }
            if (tieneHambre == true && compEstufa.contarConCarneCocida == true)
            {
                mensajeAgradecimiento.enabled = true;
                estaExigente = false;
                estaReflexivo = true;
                recompensaMaisha.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajeInteraccion.enabled = true;
            clicIzquierdo = true;
        }
        if(other.CompareTag("Player") && estaReflexivo == true) 
        {
            mensajeReflexivo.enabled = true;
            mensajeInteraccion.enabled = false;
            clicIzquierdo = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajeInteraccion.enabled = false;
            clicIzquierdo = false;
            QuitaMensajes();
        }
    }

    private void QuitaMensajes() 
    {
        mensajeTieneHambre.enabled = false;
        mensajeExigente.enabled = false;
        mensajeReflexivo.enabled = false;
        mensajeAgradecimiento.enabled = false;
    }
}
