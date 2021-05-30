
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
    }
}
