using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            GameController.crystalCount++;
            SnakeMain.crystalFever++;
            Destroy(gameObject);
        }
    }


}
