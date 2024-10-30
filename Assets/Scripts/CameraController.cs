using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Transform player;
    
    [SerializeField] private float sensitivity = 3f;

    private float _xRotation, _yRotation;
    
    private void Update() => CameraMove();
    
    private void CameraMove()
    {
        _xRotation += Input.GetAxis("Mouse X") * sensitivity;
        _yRotation += Input.GetAxis("Mouse Y") * sensitivity;

        _yRotation = Mathf.Clamp(_yRotation, -90, 90);
        playerCamera.transform.rotation = Quaternion.Euler(-_yRotation, _xRotation, 0);
        player.transform.rotation = Quaternion.Euler(0, _xRotation, 0);
    }
}
