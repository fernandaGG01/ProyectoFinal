using UnityEngine;
using TMPro;

public class Nombre : MonoBehaviour
{
    public TMP_Text nombre;

    void Start()
    {
        // Obtener el nombre de usuario guardado en Manager
        string nombreUsuario = Manager.instance.nombre_usuarioActual;

        // Verificar si el nombre de usuario está vacío
        if (!string.IsNullOrEmpty(nombreUsuario))
        {
            // Construir el mensaje de bienvenida
            string mensaje =  nombreUsuario;

            // Mostrar el mensaje en el TMP_Text
            nombre.text = mensaje;
        }
        else
        {
            // Mostrar un mensaje de error si no se encuentra el nombre de usuario
            nombre.text = "¡Error! Nombre de usuario no encontrado.";
        }
    }
}
