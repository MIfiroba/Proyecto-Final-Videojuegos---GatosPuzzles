using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPuertaPasillo : MonoBehaviour
{
    // Si el gato llega a la puerta se activa mensaje para ingresar codigo

    bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajePuerta;
    public Image imagenCodigoNumerico;

    public Animator animacion;

    void Start()
    {
        mensajePuerta.enabled = false;
        imagenCodigoNumerico.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            imagenCodigoNumerico.enabled = true;
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
            imagenCodigoNumerico.enabled = false;
        }
    }
}
