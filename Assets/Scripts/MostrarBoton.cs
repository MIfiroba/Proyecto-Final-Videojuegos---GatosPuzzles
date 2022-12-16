using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarBoton : MonoBehaviour
{
    /* Si el gato se acerca lo suficiente al papel
    entonces se mostrará el mensaje de ayuda
    Clickear para mostrar el mensaje de ayuda
    */

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public GameObject botonPanel; //public Button botonPanel;
    public GameObject manita;

    void Start()
    {
        botonPanel.SetActive(false); //botonPanel.enabled = false;
        manita.SetActive(false); //manita.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            botonPanel.SetActive(true);
            manita.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            botonPanel.SetActive(false);
            manita.SetActive(false);
        }
    }
}
