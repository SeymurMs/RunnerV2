using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle1,Obstacle2,Obstacle3;
    private float _obstacleSpawnInternal = 2.5f;
    public float ObstacleDistance;
    float time;
    void Start()
    {
       StartCoroutine("SpawnObstacles");
    }
    private void Update()
    {
        time = Time.time;
    }
    void SpawnObstacle()
    {
        if (time >= 5)
        {
            int a = Random.Range(1, 4);
            if (a == 1)
            {
                Instantiate(Obstacle1, new Vector3(transform.position.x, ObstacleDistance, 0), Quaternion.identity);
            }
            else if (a == 2)
            {
                Instantiate(Obstacle2, new Vector3(transform.position.x, ObstacleDistance, 0), Quaternion.identity);

            }
            else if (a == 3)
            {
                Instantiate(Obstacle3, new Vector3(transform.position.x, ObstacleDistance, 0), Quaternion.identity);

            }
        }


    }
        IEnumerator SpawnObstacles()
        {
            while (true)
            {
                SpawnObstacle();
                yield return new WaitForSeconds(_obstacleSpawnInternal);
            }
        }
    

}
