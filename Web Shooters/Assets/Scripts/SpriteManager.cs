//Attach this script to spawn manager
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Transform spawnTransform;

    //Sprites
    public GameObject spawnPrefab;

    //time
    public float waitTime = 10.0f;
    float currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime>= waitTime)
        {
            currentTime -= waitTime;
            Debug.Log("spawn transform: " + spawnTransform.position);
            GameObject spawned = Instantiate(spawnPrefab, spawnTransform.position, spawnTransform.rotation);
            
        }
    }
}
