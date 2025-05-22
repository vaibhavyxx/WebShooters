//Attach it with the web to play sounds when zaps spidey
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    [SerializeField] AudioSource zappedSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sprites"))
        {
            zappedSound.Play();
        }
    }
}
