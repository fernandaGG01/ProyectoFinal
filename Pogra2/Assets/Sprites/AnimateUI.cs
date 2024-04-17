using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUI : MonoBehaviour
{

    public GameObject logo;
    public GameObject fondoLogo;

    void Start()
    {
        LeanTween.moveY(logo.GetComponent<RectTransform>(), 0, 1.5f)
            .setEase(LeanTweenType.easeOutBounce)
            .setDelay(1.0f);

        LeanTween.alphaCanvas(fondoLogo.GetComponent<CanvasGroup>(), 0, 2.0f).setDelay(3.5f);
    }






}
