using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private GameInput _gameInput;

    private Character _character;
    private IControllable _controllable;
    
    private void Awake()
    {
        _gameInput = new GameInput();
        _gameInput.Enable();
        
        _character = GetComponent<Character>();
        _controllable = GetComponent<IControllable>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var inputDirection = _gameInput.Player.Move.ReadValue<Vector2>();
        var direction = new Vector3(inputDirection.x, 0, inputDirection.y);
        _controllable.Move(direction);
    }
    
    private void OnEnable()
    {
        _gameInput.Player.Jump.performed += OnJump;
    }

    private void OnDisable()
    {
        _gameInput.Player.Jump.performed -= OnJump;
    }   
    
    private void OnJump(InputAction.CallbackContext obj)
    {
        if (_character._isGrounded)
            _controllable.Jump();
    }
}
