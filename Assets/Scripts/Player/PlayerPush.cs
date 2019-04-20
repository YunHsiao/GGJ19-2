﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {

            Debug.Log("Push Enter");
            animator.SetBool("IsPushing", true);
            AudioManager.Ins.Play("push");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {

            Debug.Log("Push Exit");
        }

        animator.SetBool("IsPushing", false);
        AudioManager.Ins.Stop("push");
    }
}
