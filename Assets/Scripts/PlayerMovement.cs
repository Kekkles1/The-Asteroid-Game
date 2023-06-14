using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float thrust;
    public float rotationSpeed;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(transform.right * thrust, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.MoveRotation(body.rotation - rotationSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.MoveRotation(body.rotation + rotationSpeed);
        }
    }
}
