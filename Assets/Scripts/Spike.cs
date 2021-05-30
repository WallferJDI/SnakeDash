
using UnityEngine.SceneManagement;
using UnityEngine;

public class Spike : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SnakeMain")
        {
            GameController.deadCount = 0;
            GameController.crystalCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
            
    }
}
