using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Star;
    public GameObject Line;
    public GameObject[] Stars;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            OnEnable();
        }
    }
    void OnEnable()
    {
        Line = this.gameObject;
        Stars = GameObject.FindGameObjectsWithTag("Star");
        Star = Stars[Stars.Length - 1];
        Line.transform.position = Star.transform.position + Line.transform.localScale;
    }
}

