using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private Animator _anim;
    private bool _isOpen;
    
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void Interact()
    {
        _isOpen = !_isOpen;
        _anim.SetBool("Opened", _isOpen);
    }
}
