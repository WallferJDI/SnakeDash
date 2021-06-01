using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int deadCount;
    public static int crystalCount;
    public Text deadCountText;
    public Text crystalCountText;

    private void Update()
    {
        deadCountText.text = $"{deadCount}";
        crystalCountText.text = $"{crystalCount}";
    }
    public static void reloadScene()
    {
        deadCount = 0;
        crystalCount = 0;
        SnakeMain.crystalFever = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
