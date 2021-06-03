using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject youWIn;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            youWIn.SetActive(true);
            Destroy(other);
        }
    }

}
