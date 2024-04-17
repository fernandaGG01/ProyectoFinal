using UnityEngine;

public class RepMusic : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource que reproducirá la música
    public AudioClip cancion; // La única canción que se reproducirá

    void Start()
    {
        // Asigna la canción al AudioSource y la reproduce al iniciar el juego
        audioSource.clip = cancion;
        audioSource.Play();
    }
}