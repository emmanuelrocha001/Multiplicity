using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTile : MonoBehaviour {

  
	// Use this for initialization
	void Start ()
  {

    Quaternion[]  Rotations = { new Quaternion(0, 0, 0, 0), new Quaternion(0, 0, 90, -90), new Quaternion(0, 0, -180, 0),  new Quaternion(0, 0, 90, 90)};
    transform.rotation = Rotations[Random.Range(0, 3)];
	}
	
	// Update is called once per frame
	void Update ()
  {
    if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
    {
      Quaternion[] Rotations = { new Quaternion(0, 0, 0, 0), new Quaternion(0, 0, 90, -90), new Quaternion(0, 0, -180, 0), new Quaternion(0, 0, 90, 90) };
      transform.rotation = Rotations[Random.Range(0, 3)];
    }
    
  }
}
