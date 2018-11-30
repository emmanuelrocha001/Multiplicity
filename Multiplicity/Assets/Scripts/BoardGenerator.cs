using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour {

  // Use this for initialization
  public GameObject tile;
  public GameObject directionTile;
  public Camera mainCamera;
  private Vector3 currentTilePosition;
  public float boardSize;
  List<float> tilePosList;
  void Start ()
  {
    tilePosList = new List<float>();
    mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    boardSize = mainCamera.orthographicSize;
    boardSize *= 2;

    float xStart = boardSize * (float)1.7 * -1;
    float xEnd = xStart * -1;
    float yStart = boardSize * (float).9;
    float yEnd = yStart * -1;

     
    //Tile position, generation
    for(float y=yStart; y >= yEnd; y-=10)
    {
      for(float x = xStart; x <= xEnd; x += 10)
      {
        currentTilePosition = new Vector3(x, y);

            
       // Instantiate(gameTile, currentTilePosition, Quaternion.identity);
        Instantiate(tile, currentTilePosition, Quaternion.identity);
      }
      Instantiate(directionTile, currentTilePosition, Quaternion.identity);

    }
    }

}
