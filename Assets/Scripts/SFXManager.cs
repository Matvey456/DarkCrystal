using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip[] sounds;
    
    private AudioSource Source => GetComponent<AudioSource>();
    
    public void PlaySound(AudioClip clip, float volume = 1f)
    {
        Source.PlayOneShot(clip, volume);
    }
}
