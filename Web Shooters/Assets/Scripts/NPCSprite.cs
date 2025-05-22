//Attach it to the sprite to make sure it has a speed of x amount for movement
using UnityEngine;

public class NPCSprite : MonoBehaviour
{
    public Sprite regularSprite;
    public Sprite webbedSprite;
    Rigidbody2D rigidbody;
    Vector3 speed;
    bool isWebbed = false;

    public Vector3 Speed { get { return speed; } set {  speed = value; } }

    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = regularSprite;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = speed;
        isWebbed = false;
    }
    private void Update()
    {
        if (isWebbed)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = webbedSprite;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Web"))
        {
            isWebbed = true;
            UI.uiManager.Score++;
        }
    }

}
