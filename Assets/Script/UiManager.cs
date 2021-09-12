using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance;
    public TransitionTween transitionTween;
    public GameObject test;

    void Awake ()
        {
            if (Instance == null)
            Instance = this;
        else
            Destroy (gameObject);
  }
}
