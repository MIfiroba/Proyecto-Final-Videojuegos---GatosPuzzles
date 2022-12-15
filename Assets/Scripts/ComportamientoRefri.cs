using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoRefri : MonoBehaviour
{
    /* Si el gato llega al refri y NO tiene carne
    entonces se mostrará el mensaje de abrir.
    En caso de sí tener la carne, abrir.
    */

    //Variables necesarias para el funcionamiento del cofre
    public bool contarConCarne = false;
    public bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeInteraccion;
    public Image iconoCarne;

    private ControladorAudios controladorAudio;
    public Animator animacion;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeInteraccion.enabled = false;
        iconoCarne.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
           if(contarConCarne == false) 
            {
                mensajeInteraccion.enabled = false;
                //if (animacion != null)
                //{
                    animacion.Play("AbrePuerta");
                    controladorAudio.SeleccionAudio(3, 1f);
                    contarConCarne = true;
                    iconoCarne.enabled = true;
                //}
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && contarConCarne == false)
        {
            mensajeInteraccion.enabled = true;
            clicIzquierdo = true;
        }
        if(other.CompareTag("Player") && contarConCarne == true) 
        {
            mensajeInteraccion.enabled = false;
            clicIzquierdo = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && contarConCarne == false)
        {
            mensajeInteraccion.enabled = false;
            clicIzquierdo = false;
        }
    }
}
