using UnityEngine;
using System.IO.Ports;

public class Input : MonoBehaviour
{
    public static Input inputManager;
    //To open Arduino port and do serial communication
    SerialPort dataStream;
    public string serialPort = "COM3";
    public int baud = 9600;
    public GameObject spriteObject;

    private string recievedString;
    private float tap;

    //Return tap value from piezo
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

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (dataStream.IsOpen)
            {
                recievedString = dataStream.ReadLine();
                tap = float.Parse(recievedString); 
                Debug.Log("tap: "+ tap);
            }
        }
        catch (System.Exception error)
        {
            Debug.LogWarning("Serial read error: "+ error.Message);
        }
    }
}
