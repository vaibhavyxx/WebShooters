//Responsible for movement on update
using UnityEngine;

public class Sprite : MonoBehaviour
{
    [SerializeField] Transform destroyTransform;    //to destroy the object once it is off camera for rendering purposes

    Rigidbody2D rb;
    public float speed = -5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();     //Finds rigidbody attached to the gameobject
    }

    void Update()
    {
        rb.AddForce(Vector2.up * speed);     //Adds force at a constant speed 
        Debug.Log(this.transform.position);  //For debugging purposes

        //Did not work
        //Destroys itself once it is off camera
        if(rb.position == (Vector2)destroyTransform.position) { 
            Destroy(this.gameObject);   
        }
    }
}
