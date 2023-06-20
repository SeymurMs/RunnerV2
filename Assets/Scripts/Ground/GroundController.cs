using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public GameObject Ground0, Ground1, Ground2, Ground3, Ground4, Ground6, Ground7;
    bool hasGround = true;
    public float HasSpawn;
    public float HighGround;
    public float HighGround2;
    int Previus = 0;
    int min=1;
    int max = 7;
    private void Update()
    {

        if (!hasGround)
        {
            SpawnGround(); 
            hasGround = true;
        }

    }
    void SpawnGround()
    {
        int b = 0;
        b = Random.Range(min,max);
        #region Old IF Else
        //if (a == 1)
        //{
        //    Instantiate(Ground0, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
        //}
        //else if (a == 2)
        //{
        //    Instantiate(Ground1, new Vector3(transform.position.x + HasSpawn, HighGround2, 0), Quaternion.identity);
        //}
        //else if (a == 3)
        //{
        //    Instantiate(Ground2, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
        //}
        //else if (a == 4)
        //{
        //    Instantiate(Ground3, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);

        //}
        //else if (a == 5)
        //{
        //    Instantiate(Ground4, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);

        //}
        //else if (a == 6)
        //{
        //    Instantiate(Ground5, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);

        //}
        //else if (a == 7)
        //{
        //    Instantiate(Ground6, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);

        //}

        #endregion
        while (b == Previus)
        {
            b = Random.Range(min, max);
        }
            switch (b)
            {
                case 1:
                    Instantiate(Ground0, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Ground1, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Ground3, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Ground4, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Ground6, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
                    break;
                case 6:
                    Instantiate(Ground7, new Vector3(transform.position.x + HasSpawn, HighGround, 0), Quaternion.identity);
                    break;
                default:
                    break;

            }
        Previus = b;
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasGround = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasGround = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(collision.gameObject);
        }
    }

}
