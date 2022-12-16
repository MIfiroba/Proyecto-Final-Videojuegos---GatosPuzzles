using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPuertaHabitacion : MonoBehaviour
{
    public Animator animacion;
    public CodigoNumericoHabitacion codNumHab;

    private ControladorAudios controladorAudio;

    void Start() { controladorAudio = FindObjectOfType<ControladorAudios>(); }

    void Update()
    {
        if (codNumHab.puertaAbierta == true)
        {
            if (animacion != null)
            {
                animacion.Play("PuertaAbriendo");
            }
            //controladorAudio.SeleccionAudio(6, 1f);
        }
    }
}
