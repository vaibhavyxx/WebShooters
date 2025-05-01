using UnityEngine;
using System.IO.Ports;

public class Input : MonoBehaviour
{
    //This is a manager class so I wanted to make sure that there is one instance of it at all times
    public static Input inputManager;           
    //To open Arduino port and do serial communication
    SerialPort dataStream;
    public string serialPort = "COM3";
    public int baud = 9600;
    public GameObject spriteObject;

    private string receivedString;
    private float tap;

    /// <summary>
    /// Read-only to find the vibrations amount 
    /// </summary>
    public float Tap
    {
        get { return tap; }
    }

    //Ensures that there is only one instance of Input manager
    private void Awake()
    {
        if (inputManager != null)
        {
            GameObject.Destroy(inputManager);
        }
        else
        {
            inputManager = this;
        }
        DontDestroyOnLoad(this);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Opens the serial port to get values
        dataStream = new SerialPort(serialPort, baud);
        dataStream.Open();
    }

    void Update()
    {
        //If data stream is open, it will parse the tap value into a float which the other
        //classes can access it through Tap property
        try
        {
            if (dataStream.IsOpen)
            {
                receivedString = dataStream.ReadLine();
                tap = float.Parse(receivedString); 
                //Debug.Log("tap: "+ tap);
            }
        }
        catch (System.Exception error)
        {
            Debug.LogWarning("Serial read error: "+ error.Message);
        }
    }
}
