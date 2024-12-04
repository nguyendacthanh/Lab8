using UnityEngine;

public class galaxy2 : MonoBehaviour
{
    float loopSpeed = 2f;
    float startPosition = 8f;
    float resetposition = -8f;
    private void Update()
    {
        transform.Translate(Vector3.up * loopSpeed * Time.deltaTime);
        if (transform.position.y < resetposition)
        {
            transform.position = new Vector3(transform.position.x, startPosition, transform.position.z);
        }
    }
}
