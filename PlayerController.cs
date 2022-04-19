using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 0.5f;
    SurfaceEffector2D surfacceEffactor2D;

    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;

    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfacceEffactor2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(canMove)
        {
        RotatePlayer();
        RespondToBoost();
        }

    }


    public void DisableControls()
    {
       canMove = false; 
    }
    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfacceEffactor2D.speed = boostSpeed;
        }
        else
        {
            surfacceEffactor2D.speed = baseSpeed;
        }
    }
    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
