using System.Collections;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    [SerializeField] private Light flickeringLight;
    [SerializeField] private AudioSource flickerAudio;
    [SerializeField] private float waitTime = 3f;
    [SerializeField] private int flickerCount = 5;
    [SerializeField] private float flickerDuration = 0.1f;

    private void Start()
    {
        StartCoroutine(FlickerLight());
    }

    private IEnumerator FlickerLight()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            
            for (int i = 0; i < flickerCount; i++)
            {
                flickeringLight.enabled = !flickeringLight.enabled;
                flickerAudio.Play();
                yield return new WaitForSeconds(flickerDuration);
            }
            
            yield return new WaitForSeconds(waitTime);
        }
    }
}