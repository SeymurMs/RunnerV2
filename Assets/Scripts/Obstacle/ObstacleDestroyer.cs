using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject,2);
    }
}
