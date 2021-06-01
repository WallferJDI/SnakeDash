
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnakeMain : MonoBehaviour
{
    public float tailOffset;
    public float Speed;
    public float rotateSpeed;
    public float maxSpeed;
    public List<GameObject> tails = new List<GameObject>();
    public GameObject TailPrefab;

    public Vector3 newTailPos;
    
    public static int crystalFever;
    public static bool feverActive;

    private float SpeedFever;
    private float standartSpeed;
    Rigidbody rb;
 
    Color thisColor;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SpeedFever = Speed * 2;
        standartSpeed = Speed;
        tails.Add(gameObject);

    }
    void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    private Vector3 position;
    private float width;
    private float height;
    bool GetTouch() { return Input.GetMouseButton(0); }
    void FixedUpdate()
    {
   
        rb.velocity = transform.forward * Speed;
        if (Input.GetKey(KeyCode.D)&& feverActive == false)
           transform.Translate(Vector3.right * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)&& feverActive==false)
           transform.Translate(Vector3.left * rotateSpeed * Time.deltaTime);

       if (GetTouch())
        {
            if (SnakeMain.feverActive == false)
            {
                Vector3 pos = Input.mousePosition;
                pos.x = (pos.x - width) / width;
                position = new Vector3(pos.x, 0.0f, 0.0f);
                transform.Translate(position * rotateSpeed * Time.deltaTime);
            }
        }
    }
    private void Update()
    {
        if (crystalFever == 3 || feverActive)
            Fever();

        crystalFeverUpdate();
    }
    public void AddTail()
    {
        newTailPos = tails[tails.Count - 1].transform.position;
        newTailPos.z -= tailOffset;
        thisColor = GetComponent<Renderer>().material.color;

        tails.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
        tails[tails.Count - 1].gameObject.GetComponent<Renderer>().material.color = thisColor;

    }

    private float timeForFever = 5f;
    public void Fever()
    {
       

        feverActive = true;
        Vector3 centerPosition = transform.position;
        centerPosition.x = 0;
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
