using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPapelColores : MonoBehaviour
{
    /* Si el gato se acerca lo suficiente al papel
    entonces se mostrará el mensaje de ayuda
    Clickear para mostrar el mensaje de ayuda
    */

    //Variable para el funcionamiento del libro
    public bool clicIzquierdo = false;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajePapel;
    public Image ayudaPapel;

    void Start()
    {
        mensajePapel.enabled = false;
        ayudaPapel.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            mensajePapel.enabled = false;
            ayudaPapel.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajePapel.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajePapel.enabled = false;
            clicIzquierdo = false;
            ayudaPapel.enabled = false;
        }
    }
}
