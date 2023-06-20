using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject Player;
    public Text ScoreText;
    private void Update()
    {
        ScoreText.text = Player.transform.position.x.ToString("0") + " m";
    }
}
