
using UnityEngine;

public class TailMove : MonoBehaviour
{
    float Speed;
    private int id;
    public GameObject lastTailObj;
    public SnakeMain mainSnake;
    public Vector3 offset;
    
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMain>();
       
        lastTailObj = mainSnake.tails[mainSnake.tails.Count - 2];
        id = mainSnake.tails.IndexOf(gameObject);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Speed = mainSnake.Speed+1;
        transform.position = Vector3.Lerp(transform.position, lastTailObj.transform.position, Time.deltaTime * Speed);
    }
}
