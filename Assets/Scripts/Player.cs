using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;

    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        collider=GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
