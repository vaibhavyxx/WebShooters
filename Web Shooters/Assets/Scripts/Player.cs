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
        if(Input.inputManager.Tap > 10)
        {
            isTapped = true;
            //ideally stays active for 2 seconds
        }

        if(isTapped )
        {
            currentTime += Time.deltaTime;
            web.SetActive(true);
            if( currentTime > waitTime )
            {
                currentTime = 0;
                isTapped=false;
            }
        }
        else
        {
            web.SetActive(false);
        }
    }
}
