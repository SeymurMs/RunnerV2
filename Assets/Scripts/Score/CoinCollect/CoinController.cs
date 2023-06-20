using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public PlayerController _player;
    public int CoinVal = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            CoinCollector.instance.ChangeScore(CoinVal);
            Destroy(gameObject);

        }
        
    }
}
