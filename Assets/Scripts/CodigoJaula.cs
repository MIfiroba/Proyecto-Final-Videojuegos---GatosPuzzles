using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoJaula : MonoBehaviour
{
    private ControladorAudios controladorAudio;

    public GameObject ventanaGanar;

    string Codigo = "4586203";
    string Numero = null;
    int IndiceNumero = 0;
    string st;
    public Text UiText = null;

    public void CodigoFuncion(string digitos)
    {
        IndiceNumero++;
        Numero = Numero + digitos;
        UiText.text = Numero;
    }

    void start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
        ventanaGanar.SetActive(false);
    }

    public void Entrada()
    {
        if (Numero == Codigo)
        {
            //Ventana de ganar 
            //controladorAudio.SeleccionAudio(6, 1f);
            Debug.Log("Abriste la jaula!");
            //ganaste.ventanaGanaste();
            ventanaGanar.SetActive(true);
        }
    }

    public void Rechazo()
    {
        IndiceNumero++;
        Numero = null;
        UiText.text = Numero;
    }
}