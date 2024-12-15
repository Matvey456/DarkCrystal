using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private Volume[] postProcess;
    [SerializeField] private Slider postSlider, soundSlider;

    private float _gamma, _volume;
    
    private void Start()
    {
        postSlider.onValueChanged.AddListener(ChangeGamma);
        soundSlider.onValueChanged.AddListener(ChangeVolume);
        Load();
    }

    private void ChangeGamma(float gamma)
    {
        _gamma = gamma;
        
        foreach (var post in postProcess)
        {
            if (post.profile.TryGet<ColorAdjustments>(out var colorAdjustments))
            {
                colorAdjustments.postExposure.value = _gamma;
                Debug.Log($"New gamma: {gamma}");
            }
        }
        
        Save();
    }

    private void ChangeVolume(float volume)
    {
        _volume = volume;
        Save();
        SoundManager._instance.SetVolume(_volume);
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("PostProcessing", _gamma);
        PlayerPrefs.SetFloat("Volume", _volume);
        PlayerPrefs.Save();
    }

    private void Load()
    {
        _volume = PlayerPrefs.GetFloat("Volume", 1f);
        _gamma = PlayerPrefs.GetFloat("PostProcessing", 0f);
        Debug.Log($"Gamma value has loading: {_gamma}");
        soundSlider.value = _volume;
        postSlider.value = _gamma;
        SoundManager._instance.SetVolume(_volume);

        foreach (var post in postProcess)
        {
            if (post.profile.TryGet<ColorAdjustments>(out var colorAdjustments))
            {
                colorAdjustments.postExposure.value = _gamma;
            }
        }
    }
}
