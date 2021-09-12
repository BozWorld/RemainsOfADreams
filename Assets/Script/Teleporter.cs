using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private PlayerInput playerInput;
    public Transform teleportationPoint;
    private bool canInteract;
    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Player.Interact.performed += _ => InteractObject();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            canInteract = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            canInteract = false;
        }
    }


    private void OnEnable () 
        {

        playerInput.Enable();
        }

        private void InteractObject() 
    {
        if(canInteract == true){
            UiManager.Instance.transitionTween.fade(Teleportation);
            
            canInteract = false;
        }
        
    }

        private void Teleportation()
        {
            PlayerController.Instance.transform.position = teleportationPoint.position; 
        }
}
