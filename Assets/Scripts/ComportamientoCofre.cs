using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoCofre : MonoBehaviour
{
    /* Si el gato llega al cofre y NO tiene llave
    entonces se mostrará el mensaje de abrir cofre.
    En caso de sí tener la llave, abrir el cofre
    */

    //Variables necesarias para el funcionamiento del cofre
    public bool contarConLlave = false;
    public bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeCofre;
    public Image iconoLlave;

    private ControladorAudios controladorAudio;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeCofre.enabled = false;
        iconoLlave.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo) 
        {
            contarConLlave = true;
            iconoLlave.enabled = true;
            mensajeCofre.enabled = false;
            controladorAudio.SeleccionAudio(3, 1f);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player") && contarConLlave == false)
        {
            mensajeCofre.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player") && contarConLlave == false) 
        {
            mensajeCofre.enabled = false;
            clicIzquierdo = false;
        }
        if (other.CompareTag("Player") && contarConLlave == true)
        {
            mensajeCofre.enabled = false;
            clicIzquierdo = false;
        }
    }
}
