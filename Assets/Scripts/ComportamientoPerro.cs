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

    public bool tieneHambre = true;
    public bool estaExigente = false;
    public bool agradecimiento = false;
    public bool estaReflexivo = false;

    public bool clicIzquierdo = false;

    void Start()
    {
        mensajeTieneHambre.enabled = false;
        mensajeExigente.enabled = false;
        mensajeReflexivo.enabled = false;
        mensajeAgradecimiento.enabled = false;
        mensajeInteraccion.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo && tieneHambre)
        {
            mensajeInteraccion.enabled = false;
            mensajeTieneHambre.enabled = true;
            //mensajeExigente.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajeInteraccion.enabled = true;
            clicIzquierdo = true;
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
