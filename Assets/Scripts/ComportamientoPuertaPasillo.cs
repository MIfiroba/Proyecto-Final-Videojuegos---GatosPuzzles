using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamientoPuertaPasillo : MonoBehaviour
{
    public Animator animacion;
    public CodigoNumerico codNum;

    void Update()
    {
        if (codNum.puertaAbierta == true) 
        {
            if (animacion != null)
            {
                animacion.Play("PuertaAbriendo");
            }
        }
    }
}
