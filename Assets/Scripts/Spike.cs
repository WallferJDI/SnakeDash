
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject inpactEffect;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SnakeMain")
        {
            if (SnakeMain.feverActive == true)
            {

                Destroy(gameObject);
                Instantiate(inpactEffect, collision.transform.position, collision.transform.rotation);
                return;

            }

            GameController.reloadScene();

        }
    }
}
