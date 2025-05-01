//Attach it to the sprite to make sure it has a speed of x amount for movement
using UnityEngine;

public class Sprite : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] Vector3 speed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = speed;
    }


    //destroys itself if it collides with the web -Has issues with it
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Web"))
        {
            Debug.Log("Collided with the web");
            Destroy(this.gameObject);
        }
    }
}
