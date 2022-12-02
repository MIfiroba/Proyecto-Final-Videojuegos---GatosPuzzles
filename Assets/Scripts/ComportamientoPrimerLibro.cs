using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPrimerLibro : MonoBehaviour
{
    /* Si el gato se acerca lo suficiente al libro
    entonces se mostrará el mensaje de ayuda
    Presionar espacio para mostrar el mensaje de ayuda
    */

    //Variable para el funcionamiento del libro
    public bool presionaEspacio = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeLibro;
    public Image ayudaLibro;

    void Start()
    {
        mensajeLibro.enabled = false;
        ayudaLibro.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && presionaEspacio)
        {
            mensajeLibro.enabled = false;
            ayudaLibro.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            mensajeLibro.enabled = true;
            presionaEspacio = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            mensajeLibro.enabled = false;
            presionaEspacio = false;
        }
    }
}
