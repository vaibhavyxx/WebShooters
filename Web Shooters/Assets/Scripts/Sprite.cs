//Attach it to the sprite to make sure it has a speed of x amount for movement
using UnityEngine;

public class Sprite : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Vector3 speed;

    public Vector3 Speed { get { return speed; } set {  speed = value; } }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = speed;
    }

}
