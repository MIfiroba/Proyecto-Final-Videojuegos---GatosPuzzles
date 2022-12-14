using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Estatua : MonoBehaviour
{
    /* Si el gato llega a la estatua y NO tiene el martillo para romperlo
   entonces se mostrará el mensaje.
   En caso de sí tener el martillo, romperlo.
   */

    bool clicIzquierdo = false;
    public ComportamientoCaja compCaja;

    private ControladorAudios controladorAudio;

    // Variables para los mensajes que hice y poder interactuar con el entorno
    public Image mensajeEstatua;
    public Image iconoMartillo;
    public Image mensajeNecesitasMartillo;

    //public Animator animacion;
    public GameObject romperObjeto;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeEstatua.enabled = false;
        mensajeNecesitasMartillo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            if (compCaja.contarConMartillo == true)
            {
                mensajeEstatua.enabled = false;
                controladorAudio.SeleccionAudio(7, 1f);
                romperObjeto.SetActive(false);
            }
            if (compCaja.contarConMartillo == false)
            {
                mensajeNecesitasMartillo.enabled = true;
                mensajeEstatua.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajeEstatua.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajeEstatua.enabled = false;
            clicIzquierdo = false;
            mensajeNecesitasMartillo.enabled = false;
        }
    }
}
