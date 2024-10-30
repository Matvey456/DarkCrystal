using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour, IControllable
{
    private CharacterController _controller;
    
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundChecker;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 2f;
    [SerializeField] private float radiusDistance = 0.4f;

    private float _velocity;
    private Vector3 _direction; 
    public bool _isGrounded;

    private const float GRAVITY = -9.81F;
    
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    private void FixedUpdate()
    {
        _isGrounded = IsGround();

        if (_isGrounded && _velocity < 0f)
            _velocity = -2f;
        
        DoGravity();
        Move(_direction);
    }

    public void Move(Vector3 direction)
    {
        _direction = direction;
        _controller.Move(_direction * speed * Time.fixedDeltaTime);
    }

    public void Jump()
    {
        _velocity += Mathf.Sqrt(jumpForce * -2 * GRAVITY);
    }

    private bool IsGround()
    {
        return Physics.CheckSphere(groundChecker.position, radiusDistance, groundLayer);
    }

    private void DoGravity()
    {
        _velocity += GRAVITY * Time.fixedDeltaTime;
        _controller.Move(Vector3.up * _velocity * Time.fixedDeltaTime);
    }
}
