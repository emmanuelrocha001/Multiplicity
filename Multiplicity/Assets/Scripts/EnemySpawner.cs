using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public GameObject[] enemies;

  private float timeBetweenSpawn;
  public float startTimeBetweenSpawn;
  public float decreaseTime;
  public float minTime;
  

  public Color[] color = { Color.green, Color.blue, Color.yellow };
  public int currentColor;
  public SpriteRenderer currentEnemy;

  // Use this for initialization
  void Start()
  {

    startTimeBetweenSpawn = 2f;
    decreaseTime = 0.05f;
    minTime = .1f;

  }

  // Update is called once per frame
  void Update()
  {


    if (timeBetweenSpawn <= 0)
    {
      currentEnemy = enemies[0].GetComponent<SpriteRenderer>();
      currentColor = Random.Range(0, color.Length);
      currentEnemy.color = color[currentColor];


      Instantiate(enemies[0], transform.position, Quaternion.identity);

      timeBetweenSpawn = startTimeBetweenSpawn;

      if (startTimeBetweenSpawn > minTime)
        startTimeBetweenSpawn -= decreaseTime;
    }
    else
    {
      timeBetweenSpawn -= Time.deltaTime;
    }

  }

  
}