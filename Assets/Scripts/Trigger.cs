using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private bool active;

    private void OnTriggerEnter(Collider other)
    {
        target.SetActive(active);
    }
}
