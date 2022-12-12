using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    //private Animator _anim;
    public float movementSpeed;
    private Vector2 _movementInput;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        //_anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
        //Animate();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal == 0 && vertical == 0)
        {
            //_anim.Play("PlayerIdle");
            _rigidbody2D.velocity = new Vector2(0, 0);
            return;
        }

        // if (horizontal > 0 && vertical == 0)
        //     anim.Play("PlayerMoveRight");
        //
        // if(horizontal < 0 && vertical == 0)
        //     anim.Play("PlayerMoveLeft");
        //
        // if (vertical > 0)
        // {
        //     if(horizontal == 0)
        //         anim.Play("PlayerMoveDown");
        //     else if (horizontal > 0)
        //         anim.Play("PlayerMoveRightDown");
        //     else
        //         anim.Play("PlayerMoveLeftDown");
        // }
        //
        // if (vertical > 0)
        // {
        //     if(horizontal == 0)
        //         anim.Play("PlayerMoveUp");
        //     else if (horizontal > 0)
        //         anim.Play("PlayerMoveUpRight");
        //     else
        //         anim.Play("PlayerMoveUpLeft");
        // }
        _movementInput = new Vector2(horizontal, vertical);
        _rigidbody2D.velocity = _movementInput * movementSpeed * Time.fixedDeltaTime;
    }

    private void Animate()
    {
        
    }
}
