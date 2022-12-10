using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudios : MonoBehaviour
{
    [SerializeField] private AudioClip[] sonidos;

    public AudioSource controlAudio;

    private void Start()
    {
        controlAudio = GetComponent<AudioSource>();
    }

    public void SeleccionAudio(int indice, float volumen)
    {
        controlAudio.PlayOneShot(sonidos[indice], volumen);
    }
}