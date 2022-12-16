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
    [SerializeField] private GameObject imagenMaishaExpandido;

    [SerializeField] private GameObject botonPanelNumerico;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject menuPanelHabitacion;
    [SerializeField] private GameObject menuPanelJaula;

    [SerializeField] private GameObject ventanaGanar;

    private ControladorAudios controladorAudio;

    void start()
    {
        controladorAudio = FindObjectOfType<ControladorAudios>();
    }

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

    public void abrePanelNumerico() 
    {
        menuPanel.SetActive(true);
    }

    public void abrePanelNumericoHabiatacion()
    {
        menuPanelHabitacion.SetActive(true);
    }

    public void abrePanelJaula() 
    {
        menuPanelJaula.SetActive(true);
    }

    public void cierraPanelJaula()
    {
        menuPanelJaula.SetActive(false);
    }

    public void cierraPanelNumerico() 
    {
        menuPanel.SetActive(false);
    }

    public void cierraPanelNumericoHabitacion() 
    {
        menuPanelHabitacion.SetActive(false);
    }

    public void abreImagenMaisha() 
    {
        imagenMaishaExpandido.SetActive(true);
    }

    public void cierraImagenMaisha() 
    {
        imagenMaishaExpandido.SetActive(false);
    }
}
