using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoCofre : MonoBehaviour
{
    /* Si el gato llega al cofre y NO tiene llave
    entonces se mostrará el mensaje de abrir cofre.
    En caso de sí tener la llave, presionar espacio para abrir el cofre
    */

    //Variables necesarias para el funcionamiento del cofre
    public bool contarConLlave = false;
    public bool presionaEspacio = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeCofre;
    public Image iconoLlave;

    void Start()
    {
        mensajeCofre.enabled = false;
        iconoLlave.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && presionaEspacio) 
        {
            contarConLlave = true;
            iconoLlave.enabled = true;
            mensajeCofre.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player") && contarConLlave == false)
        {
            mensajeCofre.enabled = true;
            presionaEspacio = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player") && contarConLlave == false) 
        {
            mensajeCofre.enabled = false;
            presionaEspacio = false;
        }
    }
}
