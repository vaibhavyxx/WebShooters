using UnityEngine;

public class Sprite : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] Vector3 speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
