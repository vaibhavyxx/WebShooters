//Attach it to the web
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject web;
    float currentTime;
    public float waitTime = 1.0f;
    bool isTapped = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        web.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.inputManager.Tap >= 10)
        {
            web.SetActive(true);
        }
        else
        {
            web.SetActive(false);
        }
        /*Debug.Log("From input manager: " + Input.inputManager.Tap);

        if (Input.inputManager.Tap >= 10)
        {
            currentTime += Time.deltaTime;
            isTapped = true;
        }

        if(isTapped && currentTime < waitTime)
        {
            web.SetActive(true);
        }

        //if it passes over 2 seconds, the object is hidden and is not tapped anymore
       if(currentTime >= waitTime)
        {
            currentTime = 0.0f;
            web.SetActive(false);
            isTapped=false;
        }*/

    }
}
