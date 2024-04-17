using UnityEngine;

public class RepMusic : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource que reproducir� la m�sica
    public AudioClip cancion; // La �nica canci�n que se reproducir�

    void Start()
    {
        // Asigna la canci�n al AudioSource y la reproduce al iniciar el juego
        audioSource.clip = cancion;
        audioSource.Play();
    }
}