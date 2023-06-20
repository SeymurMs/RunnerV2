using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public static CoinCollector instance;
    public Text text;
    int score;
    public PlayerController Player;
    public AudioSource audioSource;
    private void Update()
    {
        //CoinCollect.text = Player.Count.ToString() + "Coin";
        if (instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int CoinVal)
    {
        audioSource.Play();
        score += CoinVal; 
        text.text = score.ToString() + "Full";
    }

}
