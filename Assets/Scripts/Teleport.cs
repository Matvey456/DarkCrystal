using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject crystal;
    [SerializeField] private VisualEffect effect;
    [SerializeField] private float borderLeft, borderRight, borderTop, borderBottom;
    [SerializeField] private int spawnCooldown;
    
    private void Start()
    {
        StartCoroutine(Teleportation());
    }
    
    private IEnumerator Teleportation()
    {
        while (true)
        {
            effect.Play();
            crystal.SetActive(false);
            yield return new WaitForSeconds(1);
            
            var randomPositionX = Random.Range(borderLeft, borderRight);
            var randomPositionZ = Random.Range(borderTop, borderBottom);

            crystal.transform.position = new Vector3(randomPositionX, crystal.transform.position.y, randomPositionZ);
            crystal.SetActive(true);
            yield return new WaitForSeconds(spawnCooldown);
        }
    }
}
