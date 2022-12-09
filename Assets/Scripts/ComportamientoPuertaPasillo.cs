using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPuertaPasillo : MonoBehaviour
{
    // Si el gato llega a la puerta se activa mensaje para ingresar codigo

    public Animator animacion;

    void Update()
    {

        if (animacion != null)
        {
            animacion.Play("PuertaAbriendo");
        }
    }
}
