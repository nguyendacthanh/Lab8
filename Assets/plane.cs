using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plane : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveSpeed = 20f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }



    private void desstroychicken(GameObject chicken)
    {
        Destroy(chicken);
    }

    void reloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
