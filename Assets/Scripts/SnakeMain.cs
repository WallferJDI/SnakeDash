
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
    
    public static int crystalFever;
   
    private float SpeedFever;
    private float standartSpeed;
    Rigidbody rb;
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SpeedFever = Speed * 2;
        standartSpeed = Speed;
        tails.Add(gameObject);

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)&& feverActive == false)
            transform.Translate(Vector3.right * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)&& feverActive==false)
            transform.Translate(Vector3.left * rotateSpeed * Time.deltaTime);


        if (crystalFever == 3 || feverActive)
            Fever();

        crystalFeverUpdate();
        
    }
    public void AddTail()
    {
        newTailPos = tails[tails.Count - 1].transform.position;
        newTailPos.z -= tailOffset;

        tails.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
        
    }

    public static bool feverActive;
    private float timeForFever = 5f;
    public void Fever()
    {
       

        feverActive = true;
        Vector3 centerPosition = transform.position;
        centerPosition.x = 0;
        centerPosition.y = 0;
        transform.position = Vector3.Lerp(transform.position, centerPosition, Time.deltaTime * rotateSpeed);
        Speed = SpeedFever;
        timeForFever -= Time.deltaTime;
        if (timeForFever <= 0)
        {
            feverActive = false;
            Debug.Log("UPDATE");
            timeForFever = 5f;
         Speed = standartSpeed;
            crystalFever = 0;
         
        }
           

    }
    float feverUpdate = 5f;
    void crystalFeverUpdate()
    {
        feverUpdate -= Time.deltaTime;
        if (feverUpdate <= 0)
        {
            Debug.Log("FULL UPDATE");
            crystalFever = 0;
            feverUpdate = 5f;
        }
            
            
     

    }

    

}
