using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInventario : MonoBehaviour
{
    // Script que controla el inventario para ver los objetos 
    // recogidos por nuestro gato en el juego. Tambien puede 
    // servir como controlador de la musica

    [SerializeField] private GameObject botonInventario;
    [SerializeField] private GameObject menuInventario;

    public void abreInventario() 
    {
        Time.timeScale = 0f;
        botonInventario.SetActive(false);
        menuInventario.SetActive(true);
    }

    public void cierraInventario()
    {
        Time.timeScale = 1f;
        botonInventario.SetActive(true);
        menuInventario.SetActive(false);
    }
}
