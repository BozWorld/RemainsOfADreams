using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interact : MonoBehaviour
{

    [Multiline] public string text = "";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            UiManager.Instance.test.GetComponent<TextMeshProUGUI>().text = "";
            UiManager.Instance.test.GetComponent<TextMeshProUGUI>().text += text;
        }
    }
}
