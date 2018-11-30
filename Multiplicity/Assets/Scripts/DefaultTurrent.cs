using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTurrent : MonoBehaviour {

    float rotationCounter;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            transform.SetPositionAndRotation(transform.position, new Quaternion(0, 0, rotationCounter, 0));
            rotationCounter = rotationCounter + 25;
            if (rotationCounter > 360)
                rotationCounter = 0;
        }
      

        
	}
}
