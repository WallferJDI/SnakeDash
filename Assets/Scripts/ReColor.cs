
using UnityEngine;

public class ReColor : MonoBehaviour
{
    Color thisColor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain")|| other.CompareTag("Tail"))
        {
            thisColor = GetComponent<Renderer>().material.color;
            other.gameObject.GetComponent<Renderer>().material.color = thisColor;
        }
    }
}
