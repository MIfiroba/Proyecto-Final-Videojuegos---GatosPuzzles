using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mueble : MonoBehaviour
{
    /* Si el gato llega al mueble y NO tiene el control remoto
    entonces se mostrará el mensaje abrir.
    */

    //Variables necesarias para el funcionamiento del cofre
    public bool contarConControl = false;
    public bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeMueble;
    public Image iconoControl;

    private ControladorAudios controladorAudio;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeMueble.enabled = false;
        iconoControl.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            contarConControl = true;
            iconoControl.enabled = true;
            mensajeMueble.enabled = false;
            // controladorAudio.SeleccionAudio(3, 1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && contarConControl == false)
        {
            mensajeMueble.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && contarConControl == false)
        {
            mensajeMueble.enabled = false;
            clicIzquierdo = false;
        }
    }
}