using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGameController : MonoBehaviour
{
    [SerializeField] private PlayerController Player;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject Gameover; 
    private void Update()
    {
        if (Player.GameOver)
        {
            button.SetActive(true);
            Gameover.SetActive(true);

        }
    }
    public void RestartGame()
    {
        Player.GameOver = false ;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
