using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider hBar;
    public Transform playerPos;
    public RectTransform hBarPosition;
    void Start()
    {
        hBar.value = 1;
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        hBarPosition = hBar.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {

        hBarPosition.anchoredPosition  = playerPos.localPosition;

    }
}
