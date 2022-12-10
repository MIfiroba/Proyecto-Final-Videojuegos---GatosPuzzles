using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CodigoNumerico : MonoBehaviour
{
    private ControladorAudios controladorAudio;

    string Codigo = "2513";
    string Numero = null;
    int IndiceNumero = 0;
    string st;
    public Text UiText = null;
    public bool puertaAbierta = false;

    public void CodigoFuncion(string digitos) 
    {
        IndiceNumero++;
        Numero = Numero + digitos;
        UiText.text = Numero;
    }

    void start() 
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
    }

    public void Entrada() 
    {
        if(Numero == Codigo) 
        {
            //AbrirPuerta
            puertaAbierta = true;
            //controladorAudio.SeleccionAudio(6, 1f);
            Debug.Log("Abriste la puerta!");
        }
    }

    public void Rechazo() 
    {
        IndiceNumero++;
        Numero = null;
        UiText.text = Numero;
    }
}
