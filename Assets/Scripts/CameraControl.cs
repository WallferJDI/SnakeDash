
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform snake;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - snake.position;
    }

    void FixedUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z + snake.position.z);
        transform.position = newPosition;
    }
}
