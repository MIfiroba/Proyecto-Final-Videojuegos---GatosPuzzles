using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPuerta : MonoBehaviour
{
    /* Si el gato llega a la puerta y NO tiene llave
   entonces se mostrará el mensaje de abrir la puerta.
   En caso de sí tener la llave, presionar espacio para abrir la puerta
   */

    bool clicIzquierdo = false;
    public ComportamientoCofre compCofre;

    private ControladorAudios controladorAudio;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajePuerta;
    public Image iconoLlave;
    public Image mensajeNecesitasLlave;

    public Animator animacion;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajePuerta.enabled = false;
        mensajeNecesitasLlave.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo) 
        {
            if(compCofre.contarConLlave == true) 
            {
                mensajePuerta.enabled = false;
                if(animacion != null) 
                {
                    animacion.Play("PuertaAbriendo");
                    controladorAudio.SeleccionAudio(2, 1f);
                }
       
            }
            if(compCofre.contarConLlave == false) 
            {
                mensajeNecesitasLlave.enabled = true;
                mensajePuerta.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajePuerta.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajePuerta.enabled = false;
            clicIzquierdo = false;
            mensajeNecesitasLlave.enabled = false;
        }
    }
}
