using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager _instance;
    
    [SerializeField] private AudioSource BGMusic;
    
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start() => BGMusic.volume = PlayerPrefs.GetFloat("volume", 1f);

    public void PlayBackgroundMusic() => BGMusic.Play();
    
    public void StopBackgroundMusic() => BGMusic.Stop();

    public void SetVolume(float volume) => BGMusic.volume = volume;
}
