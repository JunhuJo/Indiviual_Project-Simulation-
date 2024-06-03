using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private Vector2 moveInput;
    private Vector2 jumpInput;
    private Rigidbody rb;
    public float jumpPower = 2;
    public float rotspeed = 150.0f;
    public float moveSpeed = 5f;
    public PlayerInput playerInput;
    public Animator anim;

    
    private void Start()
    {
        anim = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();

        playerInput.actions["Move"].performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        playerInput.actions["Move"].canceled += _ => moveInput = Vector2.zero;

        playerInput.actions["Jump"].canceled += ctx => jumpInput = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveInput.y * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * moveInput.x * rotspeed *Time.deltaTime);
        
        anim.SetFloat("Xspeed", moveInput.x);
        anim.SetFloat("Yspeed", moveInput.y);
    }
}
