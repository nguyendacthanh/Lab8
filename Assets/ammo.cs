using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("taget")) { }
        Destroy(gameObject);
        Destroy(collision.gameObject);

    }
}
