//Attach it to the web
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject web;              //Object you want to hide/show
    float currentTime;                  //For display purposes
    public float waitTime = 0.5f;       //Waiting period
    bool isTapped = false;

    //Web is hidden in the start
    void Start()
    {
        web.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //If any input tap is greater than 20, only then, display the web for x amount of seconds
        //before hiding it again
        if(Input.inputManager.Tap > 25)
        {
            isTapped = true;
        }

        //If it goes past the wait time, reset the current time and set isTapped to false
        if(isTapped)
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
