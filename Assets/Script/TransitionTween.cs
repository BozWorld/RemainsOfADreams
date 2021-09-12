using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TransitionTween : MonoBehaviour
{
    public GameObject background;
    public CanvasGroup canvasGroup;
    public LeanTweenType tweening;
    public delegate void TestDelegate();
    public float fadeTime = 2f;

    public void fade(Action function)  
    {
        LeanTween.alphaCanvas(canvasGroup, 1, fadeTime).setEase(tweening).setLoopPingPong(1).setOnComplete(function);
    }   
}
