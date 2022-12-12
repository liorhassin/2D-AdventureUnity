using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    //private Animator anim;
    public float movementSpeed;
    private Vector2 _movementInput;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
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
            //anim.SetBool("RunningLeft", false);
            //anim.SetBool("RunningRight", false);
            _rigidbody2D.velocity = new Vector2(0, 0);
            return;
        }
        
        //if (horizontal < 0 && vertical == 0) // Move Left
        //{
        //    anim.SetBool("RunningLeft", true);
        //}
        //else if (horizontal > 0 && vertical == 0) // Move Right
        //{
        //    anim.SetBool("RunningRight", true);
        //}
        _movementInput = new Vector2(horizontal, vertical);
        _rigidbody2D.velocity = _movementInput * movementSpeed * Time.fixedDeltaTime;
    }

    private void Animate()
    {
        
    }
}
