//Attach this script to spawn manager to ensure sprites are spawned every 'x' seconds
//And are removed once they are off screen
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Transform spawnTransform;

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

    //Removes an item from the list
    public void RemoveItem(int index)
    {
        GameObject item = SpawnedItems[index];
        Destroy(item);
        spawnedItems.RemoveAt(index);
    }

    //Creates the list and starts the time
    void Start()
    {
        spawnedItems = new List<GameObject>();
        currentTime = Time.time;
    }

    // For every 'x' amount of seconds, a sprite is spawned which is destroyed 5 seconds later
    //This is hack for it to be long enough off the camera to destroy the object
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
