using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private PlayerInput playerInput;
    private Rigidbody2D rb;
    private bool canInteract;
    public static PlayerController Instance;
    [SerializeField] private float speed = 10f;

    public Animator animator;

    private float moveSpeed = 5;

    private void Awake () {
        playerInput = new PlayerInput ();
        playerInput.Player.Interact.performed += _ => InteractObject();
        playerInput.Player.Stop.canceled += _ => StopInteraction();
        rb = GetComponent<Rigidbody2D> ();
        if (Instance == null)
            Instance = this;
        else
            Destroy (gameObject);
    }

    private void OnEnable () 
    {

        playerInput.Enable();
    }


    private void OnDisable() 
    {
        playerInput.Disable();
    }

    void FixedUpdate() 
    {
        Vector2 moveInput = playerInput.Player.Move.ReadValue<Vector2>();
        animator.SetFloat("Horizontal", moveInput.x);
        animator.SetFloat("Vertical", moveInput.y);
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
        rb.velocity = moveInput * speed;
    }

    private void InteractObject() 
    {
        if(canInteract == true)
        {
            UiManager.Instance.test.SetActive(true);
        }
            
    }

    private void StopInteraction()
    {
        if(canInteract == true)
        {
            UiManager.Instance.test.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Object")){
            canInteract = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Object")){
            canInteract = false;
            UiManager.Instance.test.SetActive(false);
        }
    }
}