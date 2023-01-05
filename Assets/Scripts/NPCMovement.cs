using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float walkSpeed;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int WalkDirection;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;
            
            

            switch (WalkDirection)
            {
                case 0:
                    rb.velocity = new Vector2(0, walkSpeed);
                    break;

                case 1:
                    rb.velocity = new Vector2(walkSpeed, 0);
                    break;

                case 2:
                    rb.velocity = new Vector2(0, -walkSpeed);
                    break;

                case 3:
                    rb.velocity = new Vector2(-walkSpeed, 0);
                    break;
            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }


        }
        else
        {
            waitCounter -= Time.deltaTime;

            rb.velocity = Vector2.zero;

            if(waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
