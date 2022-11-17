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

    bool presionaEspacio = false;
    public ComportamientoCofre compCofre;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajePuerta;
    public Image iconoLlave;
    public Image mensajeNecesitasLlave;

    public Animator animacion;

    void Start()
    {
        mensajePuerta.enabled = false;
        mensajeNecesitasLlave.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && presionaEspacio) 
        {
            if(compCofre.contarConLlave == true) 
            {
                compCofre.iconoLlave.enabled = false;
                mensajePuerta.enabled = false;
                if(animacion != null) 
                {
                    animacion.Play("PuertaAbriendo");
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
            presionaEspacio = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajePuerta.enabled = false;
            presionaEspacio = false;
            mensajeNecesitasLlave.enabled = false;
        }
    }
}
