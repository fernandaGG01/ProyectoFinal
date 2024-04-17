using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{
    public static Singleton instancia;
    public AudioSource audioSource;
    public Slider volumenSlider;
    public string nombre;
    public bool audio;
    public float volumen;

    public AudioClip cancion; // Referencia a la canción que se reproducirá

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        // Configura el AudioSource con la canción deseada y la reproduce al iniciar el juego
        audioSource.clip = cancion;
        audioSource.Play();

        // Configura el valor inicial del Slider al volumen actual
        if (volumenSlider != null)
        {
            volumenSlider.value = AudioListener.volume;
        }
    }

    // Método llamado cuando se cambia el valor del Slider
    public void CambiarVolumen()
    {
        // Ajustar el volumen según el valor del Slider
        AudioListener.volume = volumenSlider.value;
        audioSource.volume = volumenSlider.value;
    }

    private void Update()
    {
        audioSource.volume = volumen;
    }
}