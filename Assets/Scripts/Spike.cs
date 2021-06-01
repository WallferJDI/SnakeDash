

using UnityEngine;

public class Spike : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SnakeMain")
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
