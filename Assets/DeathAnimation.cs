using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = base.GetComponent<Enemy>();

        if ( enemy==null) 
        {

            animator.SetTrigger("Asteroid_Boom");
        }
    }
}
