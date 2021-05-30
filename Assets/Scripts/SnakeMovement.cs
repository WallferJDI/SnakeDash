using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnakeMovement : MonoBehaviour
{
    public float tailOffset;
    public float Speed;
    public float rotateSpeed;
    public List<GameObject> tails = new List<GameObject>();
    public GameObject TailPrefab;

    void Start()
    {
        
        tails.Add(gameObject);

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * rotateSpeed * Time.deltaTime);
        
    }
    public void AddTail()
    {
        Vector3 newTailPos = tails[tails.Count - 1].transform.position;
        newTailPos.z -= tailOffset;

        tails.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);

        
    }
}
