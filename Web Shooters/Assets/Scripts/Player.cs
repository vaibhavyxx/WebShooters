//Attach it to the web
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject web;
    //float currentTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        web.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.inputManager.Tap > 15)
        {
            Debug.Log("From player class: "+ Input.inputManager.Tap);
            web.SetActive(true);
        }
        else
        {
            web.SetActive(false);
        }
    }
}
