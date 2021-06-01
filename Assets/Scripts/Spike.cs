

using UnityEngine;

public class Spike : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (SnakeMain.feverActive == true)
            {
                Destroy(gameObject);
                return;

            }

            GameController.reloadScene();

        }
    }
}
