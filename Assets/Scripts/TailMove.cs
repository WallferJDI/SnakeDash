using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TailMove : MonoBehaviour
{
    public float Speed;
    private int id;
    public GameObject lastTailObj;
    public Vector3 lastTail;
    public SnakeMovement mainSnake;
    
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        Speed = mainSnake.rotateSpeed;
        lastTailObj = mainSnake.tails[mainSnake.tails.Count - 2];
        id = mainSnake.tails.IndexOf(gameObject);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lastTail = lastTailObj.transform.position;
        transform.LookAt(lastTail);
        transform.position = Vector3.Lerp(transform.position, lastTail, Time.deltaTime * Speed);
    }
}
