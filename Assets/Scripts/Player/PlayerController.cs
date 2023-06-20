using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Speed Settings")]
    public float PlayerSpeed;
    public float MaxSpeed;
    private float _increaseSpeedTime;
    private float _changeTimer = 100;

    [Space]
    [Header("Animation")]
    public Animator Anim;
    public AudioSource Ha;
    public AudioSource Ho;


    [Header("Player Jump Settings")]
    public Rigidbody2D Rb;
    public float JumpForce;
    public LayerMask GroundLayer;
    private float _currentJump = 2;
    private bool _isGround = true;
    private BoxCollider2D _bx2d;
    public bool GameOver = false;
    public int Count;
    public float Max;
    private void Awake()
    {
        _bx2d = GetComponent<BoxCollider2D>();
        Anim = GetComponent<Animator>();
    }
    private void Update()
    {
        EndlessRun();
        Jump();
        GameStop();
        FastDown();
        if (IsGround())
        {
            Anim.SetBool("IsFall", false);
            Anim.SetBool("IsRun", true);
            Anim.SetBool("IsWalk", true);
        }
    }
    void FastDown()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Rb.AddForce(Vector2.down * 30f, ForceMode2D.Impulse);
        }
    }
    void Jump()
    {

        if (Input.GetButtonDown("Jump") && (IsGround() || _currentJump > 0))
        {
            Anim.SetBool("IsJump", true);
            Anim.SetBool("IsWalk", false);
            Anim.SetBool("IsRun", false);
            //  Rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            Rb.velocity = Vector2.up * JumpForce;
            _currentJump--;
            if (_currentJump == 1)
            {
                Ha.Play();
            }
            else
            {
                Ho.Play();
            }
        }
        if(Rb.velocity.y <-7f)
        {
            Anim.SetBool("IsFall", true);
            Anim.SetBool("IsJump", false);
        }
    }
    bool IsGround()
    {
        float extraHeightText = 1f;
        RaycastHit2D rd = Physics2D.Raycast(_bx2d.bounds.center, Vector2.down, _bx2d.bounds.extents.y + extraHeightText, GroundLayer);
        Color rayColor;
        if (rd.collider != null)
        {
            rayColor = Color.green;
            _currentJump = 2;
        }
        else
        {
            rayColor = Color.red;
        }
        return rd.collider != null;

    }
    void EndlessRun()
    {
        _increaseSpeedTime = transform.position.x;
        if (PlayerSpeed <= MaxSpeed)
        {
            PlayerSpeed += 0.01f;
        }
        else if (_increaseSpeedTime >= _changeTimer)
        {
            _changeTimer += 1000;
            MaxSpeed += 5;
        }
        transform.Translate(Vector2.right * (PlayerSpeed * Time.deltaTime));
        if (MaxSpeed == 10)
        {
            Anim.SetBool("hundredM", true);
        }

    }
    #region Old Check Ground    
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        _currentJump = 2;
    //        _isGround = true;
    //    }
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        _isGround = false;
    //    }
    //}

    #endregion
    void GameStop()
    {
        if (GameOver)
        {
            Time.timeScale = 0;
        }
        if (gameObject.transform.position.y < 0.37f)
        {
            Time.timeScale = 0;
            GameOver = true;
        }
        if (!GameOver)
        {
            Time.timeScale = 1;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver = true;
        }
    }

}

