using UnityEngine;
using UnityEngine.UI;

public class CambiarPaneel : MonoBehaviour
{
    [SerializeField] private GameObject[] paneles; // Array de los paneles del tutorial
    

    private int panelActual = 0; // �ndice del panel actual en el carrusel

    // M�todo para cambiar de panel en el carrusel
    public void CambiarPanel(int nuevoIndice)
    {
        // Ocultar el panel actual
        paneles[panelActual].SetActive(false);

        // Mostrar el nuevo panel
        paneles[nuevoIndice].SetActive(true);

        // Actualizar el �ndice del panel actual
        panelActual = nuevoIndice;

       
    }

   
    
}