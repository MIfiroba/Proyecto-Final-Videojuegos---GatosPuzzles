using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Television : MonoBehaviour
{

    //Variables necesarias para el funcionamiento del cofre
    public bool clicIzquierdo = false;
    public Image mensajeTele;
    public Image ayudaTele;
    public Image mensajeNecesitasControl;

    public Mueble mueble;
    private ControladorAudios controladorAudio;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        mensajeTele.enabled = false;
        ayudaTele.enabled = false;
        mensajeNecesitasControl.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && clicIzquierdo)
        {
            mensajeTele.enabled = false;
            if (mueble.contarConControl == true)
            {
                ayudaTele.enabled = true;
                controladorAudio.SeleccionAudio(1, 1f);
            }
            if (mueble.contarConControl == false)
            {
                mensajeNecesitasControl.enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            mensajeTele.enabled = true;
            clicIzquierdo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mensajeTele.enabled = false;
            clicIzquierdo = false;
            mensajeNecesitasControl.enabled = false;
            ayudaTele.enabled = false;
        }
    }
}