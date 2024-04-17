using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video; // Import Video namespace

public class VideoPlayerController : MonoBehaviour
{
    public VideoClip videoClip; // Use VideoClip instead of MovieTexture
    private RawImage rawImage;
    private VideoPlayer videoPlayer;

    void Start()
    {
        rawImage = GetComponent<RawImage>();

        // Create a new VideoPlayer component
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        // Set the video clip to play
        videoPlayer.clip = videoClip;

        // Set the video player's target texture to the RawImage's texture
        videoPlayer.targetTexture = new RenderTexture((int)videoClip.width, (int)videoClip.height, 0);
        rawImage.texture = videoPlayer.targetTexture;

        // Play the video
        videoPlayer.Play();
    }
}