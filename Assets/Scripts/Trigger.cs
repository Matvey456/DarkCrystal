using UnityEngine;

public class Trigger : SFXManager
{
    [SerializeField] private GameObject target;
    [SerializeField] private bool active;

    private void OnTriggerEnter(Collider other)
    {
        PlaySound(sounds[0]);
        target.SetActive(active);
    }
}
