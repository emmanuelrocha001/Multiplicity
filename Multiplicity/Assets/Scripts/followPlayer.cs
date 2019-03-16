using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    Transform playerPos;
    RectTransform UIPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        UIPos = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        UIPos.position = playerPos.position;
        Debug.Log(UIPos.position);
    }
}
