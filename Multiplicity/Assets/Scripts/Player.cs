using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    Vector3 newPos;
    public float xIncrement;
    public float yIncrement;
    public float dIncrement;
    public float playerSpeed;
    public Quaternion cDirection;
    public GameObject effect;

    //Dash
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    //
    public bool playerIsDashing;

    //Action Sensor
    public GameObject sensor;
	// Use this for initialization
	void Start ()
    {

        rb = GetComponent<Rigidbody2D>();
        //sensor = GameObject.FindGameObjectWithTag("action_sensor");
        playerIsDashing = false;
        dashTime = startDashTime;
        startDashTime = .15f;
        dashSpeed =200;
       // effect = GameObject.FindGameObjectWithTag("player_effect");//.GetComponent<Effector2D>();
        playerSpeed = 30;
        xIncrement = 10;
        yIncrement = 10;
        dIncrement = 90;
        
     
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerMovement();
        Dash();
        
	}

    private void LateUpdate()
    {
        Action();
    }

    void Action()
    {

        if (sensor.GetComponent<ActionSensor>().canPlaceTurrent == true)
        {
            // Debug.Log("Player can place an Object!");
        }
        else
        {
            //Debug.Log("Cannot place an Object");
        }
    }
    void PlayerMovement()
    {
        //Up
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            //dash
            direction = 3;
            //Instantiate(effect, transform.position, Quaternion.identity);

            newPos = new Vector3(transform.position.x, transform.position.y + yIncrement);
            cDirection = new Quaternion(0, 0, 0, 0);
            transform.rotation = cDirection;
            // transform.rotation = Directions[0];
            //transform.position = Vector3.MoveTowards(transform.position, newPos, playerSpeed * Time.deltaTime);
        }

        //Right
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            //Instantiate(effect, transform.position, Quaternion.identity);

            //dash
            direction = 2;
            newPos = new Vector3(transform.position.x + xIncrement, transform.position.y);
            cDirection = new Quaternion(0, 0, 90, -90);

            transform.rotation = cDirection;
            //transform.position = Vector3.MoveTowards(transform.position, newPos, playerSpeed * Time.deltaTime);
        }

        //Down
        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            //dash
            direction = 4;
            //Instantiate(effect, transform.position, Quaternion.identity);

            newPos = new Vector3(transform.position.x, transform.position.y - yIncrement);
            cDirection = new Quaternion(0, 0,-180, 0);
            

            transform.rotation = cDirection;
            //transform.position = Vector3.MoveTowards(transform.position, newPos, playerSpeed * Time.deltaTime);
        }

        //Left
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            //dash
            direction = 1;

            //Instantiate(effect, transform.position, Quaternion.identity);

            newPos = new Vector3(transform.position.x - xIncrement, transform.position.y);
            cDirection = new Quaternion(0, 0, 90, 90);

            transform.rotation = cDirection;
            //transform.position = Vector3.MoveTowards(transform.position, newPos, playerSpeed * Time.deltaTime);
        }

    }


    void Dash()
    {
        if(direction == 0)
        {
           /* if(Input.GetKeyDown(KeyCode.A))
            {
                direction = 1;
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {
                direction = 2;
            }
            else if(Input.GetKeyDown(KeyCode.W))
            {
                direction = 3;
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                direction = 4;
            }*/
        }
        else
        {
            if(dashTime <= 0)
            {
                //direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
                playerIsDashing = false;
            }
            else
            {
                dashTime -= Time.deltaTime;
                playerIsDashing = true;
                if (Input.GetKeyDown(KeyCode.L))
                {
                    Instantiate(effect, transform.position, Quaternion.identity);
                    if (direction == 1)
                    {
                        rb.velocity = Vector2.left * dashSpeed;
                    }
                    else if (direction == 2)
                    {
                        rb.velocity = Vector2.right * dashSpeed;
                    }
                    else if (direction == 3)
                    {
                        rb.velocity = Vector2.up * dashSpeed;
                    }
                    else if (direction == 4)
                    {
                        rb.velocity = Vector2.down * dashSpeed;
                    }
                }
            }

        }
    
    }
}

