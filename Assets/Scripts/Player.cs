using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    public int score = 0;
    
    [SerializeField] private float speed = 5f;

    public InputSystem_Actions inputs;

    [SerializeField] private Vector2 moveInput;

    private void Awake()
    {
        inputs = new();
    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Move.performed += OnMovement;
        inputs.Player.Move.canceled += OnMovement;
    }

    private void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

        MovementMechanism(moveInput);
    }

    private void MovementMechanism(Vector2 input)
    {
        transform.position +=  (Vector3)input * speed *Time.deltaTime;    
    }

    void Start()
    {
        
    }

   
    void Update()
    {
       
    }
}
