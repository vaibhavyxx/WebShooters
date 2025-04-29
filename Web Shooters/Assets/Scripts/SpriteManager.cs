//Attach this script to spawn manager
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Transform spawnTransform;
    public Transform destroyTransform;

    //Sprites
    public GameObject spawnPrefab;
    List<GameObject> spawnedItems;

    //time
    public float waitTime = 10.0f;
    float currentTime;

    //gives the access for spawning items
    public List<GameObject> SpawnedItems
    {
        get { return spawnedItems; }
    }

    //removes an item
    public void RemoveItem(int index)
    {
        GameObject item = SpawnedItems[index];
        Destroy(item);
        spawnedItems.RemoveAt(index);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnedItems = new List<GameObject>();
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime>= waitTime)
        {
            currentTime -= waitTime;
            GameObject spawned = Instantiate(spawnPrefab, spawnTransform.position, spawnTransform.rotation);
            spawnedItems.Add(spawned);
            Destroy(spawned, 5.0f);         //Long enough to be off camera to destroy itself
        }
        
    }
}
