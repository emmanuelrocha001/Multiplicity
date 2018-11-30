using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

  Transform currentNode;
  public float speed;
  public GameObject effect;
  public GameObject[] path;
  int currentNodeId;

  void Start()
  {
    speed = 20;
    //currentNode = GameObject.FindGameObjectWithTag("start_node").GetComponent<Transform>();
    path = GameObject.FindGameObjectsWithTag("node");

    currentNodeId = 0;

    for (int i = 0; i < path.Length; i++)
    {
      if (path[i].GetComponent<PathNode>().nodeId == currentNodeId)
      {
        currentNode = path[i].GetComponent<Transform>();
      }
    }
  }

  void Update()
  {
    for (int i = 0; i < path.Length; i++)
    {
      if(path[i].GetComponent<PathNode>().nodeId == currentNodeId)
      {
        currentNode = path[i].GetComponent<Transform>();
      }
    }
  }

  void LateUpdate()
  {
    transform.position = Vector3.MoveTowards(transform.position, currentNode.position, Time.deltaTime * speed);
    
  }

 
  void OnTriggerEnter2D(Collider2D other)
  {
    

    if(other.CompareTag("node"))
    {
      currentNodeId++;
      if(currentNodeId == (path.Length))
      {
        Instantiate(effect, transform.position, Quaternion.identity);
        // other.GetComponent<Player>().health -= damage;
        //Debug.Log(other.GetComponent<Player>().health);
        Destroy(gameObject);
        Debug.Log("reached end of path");
      }


    }

    if (other.CompareTag("Tile"))
    {
      Debug.Log("Touching Tile");
      //transform.position = new Vector3(transform.position.x, other.GetComponent<Transform>().position.y);
    }

    /*
    //other.GetComponent<SpriteRenderer>().color = Color.red;
    if (other.CompareTag("end_node"))  //player takes damage
    {


      Instantiate(effect, transform.position, Quaternion.identity);
      // other.GetComponent<Player>().health -= damage;
      //Debug.Log(other.GetComponent<Player>().health);
      Destroy(gameObject);
      Debug.Log("reached end of path");

    }
    */


  }






}
