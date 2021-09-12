using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TransitionTween : MonoBehaviour
{
    public Image background;
    public LeanTweenType easeFade;
    public LeanTweenType easeScale;
    public delegate void TestDelegate();
    public float fadeTime = 2f;
    public float scaleTime;

    public void fade(Action function)  
    {
        //LeanTween.alphaCanvas(canvasGroup, 1, fadeTime).setEase(easeFade).setOnComplete(function);
        LeanTween.alpha(background.rectTransform, 1, fadeTime).setEase(easeFade).setOnComplete(function);
    }

    public void fadeOut()
    {
        LeanTween.alpha(background.rectTransform, 0, fadeTime).setEase(easeFade);
    }   

    public void scaleIn(GameObject obj)
    {
        LeanTween.scale(obj, new Vector3(3.6313f, 3.6313f, 3.6313f), scaleTime).setEase(easeScale);
    }

    public void scaleOut(GameObject obj)
    {
        LeanTween.scale(obj, new Vector3(0f, 0f, 0f), scaleTime).setEase(easeScale);
    }
}
