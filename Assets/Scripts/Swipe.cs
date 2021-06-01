using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public static Swipe instance;
    Vector2 startTouch, swipeDelta;
    bool touchMoved;
    const float SWIPEWITH = 30;
    Vector2 TouchPosition() { return (Vector2)Input.mousePosition; }
    bool TouchStart() { return Input.GetMouseButtonDown(0); }
    bool TouchEnd() { return Input.GetMouseButtonUp(0); }
    bool GetTouch() { return Input.GetMouseButton(0); }

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }
    private Vector3 position;
    private float width;
    private float height;
    void Update()
    {
        if (GetTouch())
        {
            if (SnakeMain.feverActive == false)
            {
                Vector3 pos = Input.mousePosition;
                pos.x = (pos.x - width) / width;
                position = new Vector3(pos.x, 0.0f, 0.0f);
                transform.Translate(position * 9 * Time.deltaTime);
            }
        }
        
    }
}
