using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int deadCount;
    public static int crysctalCount;
    public Text deadCountText;
    public Text crystalCountText;

    private void Update()
    {
        deadCountText.text = $"{deadCount}";
    }
}
