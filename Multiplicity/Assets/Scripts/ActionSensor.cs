using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSensor : MonoBehaviour
{
    public bool canPlaceTurrent;
    GameObject objectSelected;
    public Color defaultObjectColor;
    // Use this for initialization
    public GameObject[] genericItems = new GameObject[3];
	void Start ()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
		if(canPlaceTurrent)
        {
            if(Input.GetKeyDown(KeyCode.K))
            {
                Instantiate(genericItems[Random.Range(0,3)], transform.position, Quaternion.identity);
            }
        }
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        SpriteRenderer currentTile = other.gameObject.GetComponent<SpriteRenderer>();

        defaultObjectColor = currentTile.color;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Tile")
        {
            canPlaceTurrent = true;
            SpriteRenderer currentTile = other.gameObject.GetComponent<SpriteRenderer>();
            
           // defaultObjectColor = Color.blue;
            currentTile.color = Color.green;
        }
        else
        {
            canPlaceTurrent = false;
        }

        if(other.tag == "end_node")
        {
      Debug.Log("Player hit node");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SpriteRenderer currentTile = other.gameObject.GetComponent<SpriteRenderer>();
        currentTile.color = defaultObjectColor;
    }



}

