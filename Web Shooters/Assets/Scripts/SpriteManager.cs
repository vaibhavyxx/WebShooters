//Attach this script to spawn manager to ensure sprites are spawned every 'x' seconds
//And are removed once they are off screen
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    //For camera and height
    [SerializeField] Camera mainCamera;
    public float heightThreshold;

    public Transform spawnTransform;

    //Sprites
    public GameObject spawnPrefab;
    List<GameObject> spawnedItems;

    //time
    public float waitTime = 10.0f;
    float currentTime;

    //Creates the list and starts the time
    void Start()
    {
        spawnedItems = new List<GameObject>();
        currentTime = Time.time;
        heightThreshold = mainCamera.orthographicSize + spawnPrefab.GetComponent<SpriteRenderer>().size.y;
    }

    void Update()
    {
        Vector2 screenPosition = mainCamera.WorldToScreenPoint(transform.position);

        //Destroys sprites if they are off-camera
        for (int i = 0; i < spawnedItems.Count; i++)
        {
            if (spawnedItems[i].GetComponent<Transform>().position.y > heightThreshold)
            {
                GameObject temp = spawnedItems[i];
                spawnedItems.RemoveAt(i);
                Destroy(temp);
            }
        }

        //Spawns sprites after every variable seconds
        currentTime += Time.deltaTime;
        if(currentTime>= waitTime)
        {
            currentTime -= waitTime;
            GameObject spawned = Instantiate(spawnPrefab, spawnTransform.position, spawnTransform.rotation);
            spawned.GetComponent<NPCSprite>().Speed = new Vector3(0.0f, 5.0f, 0.0f);
            spawnedItems.Add(spawned);
            waitTime = Random.Range(1.0f, 5.0f);
        }


    }
}
