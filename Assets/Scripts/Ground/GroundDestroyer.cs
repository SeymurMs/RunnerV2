using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroyer : MonoBehaviour
{
    public PlayerController controller;
    public int WhenDestroy;
    private void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (controller.MaxSpeed ==10)
        {
            WhenDestroy = 7;
        }else if (controller.MaxSpeed ==15) 
        {
            WhenDestroy = 5;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, WhenDestroy);
        }
    }

}
