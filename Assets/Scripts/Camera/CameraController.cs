using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region
    //[Header("Camera Speed Settings")]
    //public float PlayerSpeed;
    //public float MaxSpeed;
    //private float _increaseSpeedTime;
    //private float _changeTimer = 10;
    //public PlayerController Player;
    //private void Update()
    //{
    //    _increaseSpeedTime = Time.time;
    //    if (PlayerSpeed <= MaxSpeed)
    //    {
    //        PlayerSpeed += 0.01f;
    //    }
    //    else if (_increaseSpeedTime >= _changeTimer)
    //    {
    //        _changeTimer += 10;
    //        MaxSpeed += 5;
    //    }
    //    transform.Translate(Vector2.right * (PlayerSpeed * Time.deltaTime));
    //}

    #endregion
    [SerializeField] private Transform player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }
    private void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, transform.position.y, transform.position.z);

    }
    private void LateUpdate()
    {
        // transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, 0, player.position.z) + offset, Time.deltaTime * 3);
       // transform.position = new Vector3(player.position.x + offset.x, transform.position.y, transform.position.z);
    }

}
