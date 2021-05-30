
using UnityEngine.SceneManagement;
using UnityEngine;

public class Food : MonoBehaviour
{
    Color thisColor;
    Color snakeColor;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            thisColor = GetComponent<Renderer>().material.color;
            snakeColor = other.gameObject.GetComponent<Renderer>().material.color;
            if (thisColor.Equals(snakeColor)){
                other.GetComponent<SnakeMain>().AddTail();
                GameController.deadCount++;
                Destroy(gameObject);
            }
            else
            {
                GameController.deadCount = 0;
                GameController.crystalCount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }
            

        }
    }
}
