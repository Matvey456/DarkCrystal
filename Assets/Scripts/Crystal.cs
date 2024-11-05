using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 1f;

    private void Update() => RotateCrystal(new Vector3(0f, 0f, 90f * rotateSpeed * Time.deltaTime));
    
    private void RotateCrystal(Vector3 euler) => transform.Rotate(euler);
}
