using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Boolean touch=false;
    public Animator animator;
    public GameOver GameOverScreen;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (enemy!= null )
        {
            GameOverScreen.Display();

            animator.SetBool("Touch", true);
        }
    }
}
