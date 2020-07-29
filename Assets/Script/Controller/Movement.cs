using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    Vector2 move;
    Anim anim;
    public bool facingleft = false;
    Rigidbody2D rigidbody2D;
    Walk walk;
    private void Awake()
    {
        anim = new Anim(animator);
        move = new Vector2();
        walk = new Walk(5);
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        move = walk.WalkingVector();
        move.y = rigidbody2D.velocity.y;
        rigidbody2D.velocity = move;
        isWalk();   
    }

    private void isWalk()
    {
        Debug.Log(rigidbody2D.velocity.x);
        if (rigidbody2D.velocity.x < 0 || rigidbody2D.velocity.x > 0)
        {
            anim.Walk();
            if(rigidbody2D.velocity.x > 0 && facingleft == true)
            {
                facing(0);
                facingleft = false;
            }
            if(rigidbody2D.velocity.x < 0 && facingleft == false)
            {
                facing(180);
                facingleft = true;

            }
        }
        else
        {
            anim.StopWalk();

        }
    }
    void facing(int x)
    {
        rigidbody2D.transform.localRotation = Quaternion.Euler(0, x, 0);

    }
}
