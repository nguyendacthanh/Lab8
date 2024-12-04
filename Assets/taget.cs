using UnityEngine;

public class taget : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float random = Random.Range(0.5f, 2f);
        rb.gravityScale = random;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ammo"))
        {
            Destroy(gameObject);
            Destroy(gameObject, 5f);
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);


        }


    }
}
