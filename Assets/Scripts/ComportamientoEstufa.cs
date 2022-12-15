using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoEstufa : MonoBehaviour
{
    /* Si el gato llega a la estufa y NO tiene la carne cruda
    entonces se mostrará el mensaje de cocinar.
    En caso de sí tener la carne, cocinar la carne.
    */

    //Variables necesarias para el funcionamiento de la estufa
    public bool contarConCarneCocida = false;
    public bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeInteraccion;
    public Image iconoCarneCocida;

    private ControladorAudios controladorAudio;

    public ComportamientoRefri compRefri;
    public ComportamientoPerro compPerro;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeInteraccion.enabled = false;
        iconoCarneCocida.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo && contarConCarneCocida == false)
        {
            contarConCarneCocida = true;
            iconoCarneCocida.enabled = true;
            mensajeInteraccion.enabled = false;
            controladorAudio.SeleccionAudio(4, 1f);
            compRefri.contarConCarne = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && compRefri.contarConCarne == true && compPerro.estaExigente == true)
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
        }
    }
}
