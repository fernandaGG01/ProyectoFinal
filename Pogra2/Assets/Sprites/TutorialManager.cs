using UnityEngine;
using UnityEngine.UI;

public class CambiarPaneel : MonoBehaviour
{
    [SerializeField] private GameObject[] paneles; // Array de los paneles del tutorial
    

    private int panelActual = 0; // Índice del panel actual en el carrusel

    // Método para cambiar de panel en el carrusel
    public void CambiarPanel(int nuevoIndice)
    {
        // Ocultar el panel actual
        paneles[panelActual].SetActive(false);

        // Mostrar el nuevo panel
        paneles[nuevoIndice].SetActive(true);

        // Actualizar el índice del panel actual
        panelActual = nuevoIndice;

       
    }

   
    
}