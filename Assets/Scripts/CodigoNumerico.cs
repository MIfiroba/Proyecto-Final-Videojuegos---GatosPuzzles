using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CodigoNumerico : MonoBehaviour
{
    string Codigo = "2513";
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

    public void Entrada() 
    {
        if(Numero == Codigo) 
        {
            //AbrirPuerta
        }
    }

    public void Rechazo() 
    {
        IndiceNumero++;
        Numero = null;
        UiText.text = Numero;
    }
}
