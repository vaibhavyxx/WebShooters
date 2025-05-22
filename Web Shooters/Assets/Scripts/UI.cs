using TMPro;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI uiManager;
    public TextMeshProUGUI scoreText;
    int score = 0;

    //Updates score values
    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    //Ensures that there is only one instance of UI class
    private void Awake()
    {
        if (uiManager != null)
        {
            GameObject.Destroy(uiManager);
        }
        else
        {
            uiManager = this;
        }
        DontDestroyOnLoad(this);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+ score;
    }
}
