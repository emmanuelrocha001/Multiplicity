using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {


  public SpriteRenderer tile;
  public Transform playerPos;
  public Collider2D tileCollider;
  //public Collider2D directionTileCollider;
  public Collider2D playerCollider;

  // Use this for initialization
  void Start ()
  {
    tile = GetComponent<SpriteRenderer>();
    //tile.color = Color.gray;
	}

    // Update is called once per frame
  void Update()
  {
        CheckPlayerCollision();
  }
   
  bool CheckPlayerCollision()
  {
    //collision
    tileCollider = GetComponent<Collider2D>();
    playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();

    playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();



    if(tileCollider.IsTouching(playerCollider) == true)
    {
       if(GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().playerIsDashing == false)
      {
        playerPos.position = transform.position;
      }

      //tile.color = Color.green;
      return true;
    }
    else
    {
      //tile.color = Color.gray;
      return false;
    }
  }

    /*
  void SnapItemsToTile()
  {
    //collision
    tileCollider = GetComponent<Collider2D>();
    directionTileCollider = GameObject.FindGameObjectWithTag("direction_tile").GetComponent<Collider2D>();

    Transform tilePos = GameObject.FindGameObjectWithTag("direction_tile").GetComponent<Transform>();

    if (tileCollider.IsTouching(directionTileCollider) == true)
    {
      tilePos.position = transform.position;
    }

  }
  */

}


