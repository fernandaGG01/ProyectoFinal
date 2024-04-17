using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoClip videoClip; // El video que deseas mostrar en la Image
    public Image image; // La Image donde deseas mostrar el video

    private VideoPlayer videoPlayer; // Componente VideoPlayer para reproducir el video
    private RenderTexture renderTexture; // La textura en la que se reproducirá el video

    void Start()
    {
        // Crea un nuevo objeto VideoPlayer y asigna el videoClip
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.clip = videoClip;

        // Configura el VideoPlayer para reproducir en modo RenderTexture
        renderTexture = new RenderTexture((int)image.rectTransform.rect.width, (int)image.rectTransform.rect.height, 0);
        videoPlayer.targetTexture = renderTexture;

        // Reproduce el video
        videoPlayer.Play();

        // Crea una textura Texture2D a partir de la RenderTexture
        Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height);
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture.Apply();
        RenderTexture.active = null;

        // Crea un sprite con la textura
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        // Asigna el sprite al componente Image
        image.sprite = sprite;
    }
}