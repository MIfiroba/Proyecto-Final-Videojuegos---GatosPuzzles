using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoCaja : MonoBehaviour
{
    /* Si el gato llega a la caja y NO tiene el martillo
    entonces se mostrará el mensaje de inspeccionar caja.
    */

    //Variables necesarias para el funcionamiento del cofre
    public bool contarConMartillo = false;
    public bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeCaja;
    public Image iconoMartillo;

    private ControladorAudios controladorAudio;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeCaja.enabled = false;
        iconoMartillo.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            contarConMartillo = true;
            iconoMartillo.enabled = true;
            mensajeCaja.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && contarConMartillo == false)
        {
            mensajeCaja.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && contarConMartillo == false)
        {
            mensajeCaja.enabled = false;
            clicIzquierdo = false;
        }
    }
}
