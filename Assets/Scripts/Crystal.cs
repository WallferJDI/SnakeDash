using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    private static int crystalFever;
    SnakeMain snakeMain;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            GameController.crystalCount++;
            crystalFever++;
            
            Destroy(gameObject);
        }
    }
    public void FixedUpdate()
    {
        if (crystalFever == 3) {
            StartCoroutine(FeverCourutine());
            
        }

    }
    IEnumerator FeverCourutine()
    {
        GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMain>().Fever();
        yield return new WaitForSeconds(5);
        crystalFever = 0;
    }

}
