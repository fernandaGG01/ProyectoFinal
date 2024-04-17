using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class ChangeImage : MonoBehaviour
{
    public Image imageToChange; // Referencia al componente Image que quieres cambiar
    public Image[] otherImages; // Referencias a otros Image que también deseas cambiar
    
    private string imagePath; // Almacena la ruta de la imagen seleccionada

    // Método para llamar desde el botón
    public void OpenGallery()
    {
        // Abre la galería de imágenes del dispositivo
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Asigna la ruta de la imagen seleccionada
                imagePath = path;

                // Carga la imagen seleccionada como Sprite
                StartCoroutine(LoadImage());
            }
        }, "Seleccionar imagen", "image/*");

        Debug.Log("Permission result: " + permission);
    }

    // Corrutina para cargar la imagen desde la ruta
    private IEnumerator LoadImage()
    {
        // Carga la imagen desde la ruta
        var www = new WWW("file://" + imagePath);
        yield return www;

        // Crea una textura desde los datos de la imagen
        Texture2D texture = new Texture2D(1, 1);
        www.LoadImageIntoTexture(texture);

        // Crea un sprite desde la textura
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        // Asigna el sprite a la imagen
        imageToChange.sprite = sprite;

        // Actualiza todas las otras imágenes con el nuevo sprite
        foreach (Image otherImage in otherImages)
        {
            otherImage.sprite = sprite;
        }
    
    }
}

