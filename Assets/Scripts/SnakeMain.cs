
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnakeMain : MonoBehaviour
{
    public float tailOffset;
    public float Speed;
    public float rotateSpeed;
    public List<GameObject> tails = new List<GameObject>();
    public GameObject TailPrefab;
    public Vector3 newTailPos;

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
        newTailPos = tails[tails.Count - 1].transform.position;
        newTailPos.z -= tailOffset;

        tails.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
        
    }
  public void Fever()
    {
        Vector3 centerPosition = transform.position;
        centerPosition.x = 0;
        transform.position = Vector3.Lerp(transform.position, centerPosition, Time.deltaTime * rotateSpeed);
       
        
    }
    
}
