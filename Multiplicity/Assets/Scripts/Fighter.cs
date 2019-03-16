using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fighter : MonoBehaviour
{

    Vector3 newPos;
    Rigidbody2D rb;
    float speed;
    Vector2 vVectorCalculation;
    CapsuleCollider2D groundSensor;
    bool onGround;
    Text statUI;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundSensor = GetComponent<CapsuleCollider2D>();
        speed = 10;
        onGround = false;
        statUI = GameObject.FindGameObjectWithTag("stats").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        //check if player is on ground 

        PlayerMovement();
        if(onGround)
        {
            statUI.text = "IS ON GROUND | VELOCITY VECTOR: " + rb.velocity.ToString();
        }
        else
        {
            statUI.text = "IS ON AIR | VELOCITY VECTOR: " + rb.velocity.ToString();
        }
    }

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            rb.velocity = rb.velocity + (Vector2.right);

        }


        if (Input.GetKey(KeyCode.A) == true)
        {

            rb.velocity = rb.velocity + (Vector2.left);
        }

        if (Input.GetKey(KeyCode.Space) == true && onGround == true)
        {
            rb.velocity = rb.velocity + (Vector2.up * speed);

        }


        //rb.velocity = new Vector2(0, 0);
        /*
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Debug.Log("w pressed");
            rb.velocity = Vector2.up * speed;
        }*/
    }

    void CheckIfPlayerOnGround()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("ON GROUND");
            onGround = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("ON AIR");
            onGround = false;
        }
    }

}
