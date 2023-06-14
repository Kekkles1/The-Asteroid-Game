using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float xForce;
    public float yForce;

    private int rndx;
    private int rndy;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        rndx = Random.Range(-5, 5);
        rndy = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (rndx > 0)
        {
            body.AddForce(transform.right * xForce, ForceMode2D.Impulse);
        }

        if (rndx <=0)
        {
            body.AddForce(transform.right * -xForce, ForceMode2D.Impulse);
        }

        if (rndy > 0)
        {
            body.AddForce(transform.up * yForce, ForceMode2D.Impulse);
        }

        if (rndy<=0)
        {
            body.AddForce(transform.up * -yForce, ForceMode2D.Impulse);
        }
    }
}
