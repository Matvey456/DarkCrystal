using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    [SerializeField] private Camera interactCamera;

    [SerializeField] private LayerMask interMask;
    
    [SerializeField] private float distance = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    public void Interact()
    {
        Ray ray = new Ray(interactCamera.transform.position, interactCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance, interMask))
        {
            if (hit.transform.CompareTag("Door"))
            {
                hit.transform.GetComponent<Door>().Interact();
            }
            else if (hit.transform.CompareTag("Crystal"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }    
}