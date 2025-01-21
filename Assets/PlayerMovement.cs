using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4;

    /*
        Hier komt het volgende blok code
    */

    public Animator _animator;




    void Update()
    { 
       

        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetFloat("speed", 1);

        } else
        {
            _animator.SetFloat("speed", 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetBool("jump",true);
        }
        else
        {
            _animator.SetBool("jump", false);
        }

    }
}

