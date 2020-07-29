using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class move_player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public int speed;
    public int height;
    public GameObject check_gr;
    Animator anim;
    bool isGround = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        check_ground();
        Anim();
        Jump();
        Flip();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(transform.up * height, ForceMode2D.Impulse);
        }
    }
    void Flip()
    {
        if (Input.GetAxis("Horizontal") > 0)
            transform.rotation = Quaternion.Euler(0, 180, 0);
        if (Input.GetAxis("Horizontal") < 0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void Anim()
    {
        if (Input.GetAxis("Horizontal") != 0 && isGround)
        {
            anim.SetInteger("state", 1);
        }
        else 
        {
            if (isGround)
            {
                print(isGround);
                anim.SetInteger("state", 2);
            }
            else
                anim.SetInteger("state", 4);
        }
    }
    void check_ground()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(check_gr.transform.position, 0.2f);
        isGround = colliders.Length > 1;
        if (!isGround)
        {
            print(isGround);
            anim.SetInteger("state", 3);
        }
    }

}