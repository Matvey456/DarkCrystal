using System.Collections;
using UnityEngine;

public class IntoLight : MonoBehaviour
{
    [SerializeField] private GameObject[] lights;
    [SerializeField] private float delay = 1f;
    
    private void Start()
    {
        StartCoroutine(IlluminateLights());
    }

    private IEnumerator IlluminateLights()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            yield return new WaitForSeconds(delay);
            lights[i].SetActive(true);
        }
    }
}
