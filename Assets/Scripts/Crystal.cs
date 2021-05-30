using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    private int crystalFever;
    SnakeMain mainSnake;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            GameController.crystalCount++;
            crystalFever++;
            if (crystalFever == 3)
            {
                mainSnake.Fever();
            }
            Destroy(gameObject);
        }
    }
}
