using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class StarMapGeneration : MonoBehaviour
{
    public GameObject Star;
    public int SpawnRange = 20;//���������� ������ �� ������ ������
    public int SpawnCount = 1;//���������� ������ ����
    private GameObject SpawnPoint;//���� ������
    public GameObject Line;
    public GameObject[] Stars;
    GameObject Test1;
    GameObject Test2;

    void OnEnable()
    {
        //int a = GetComponent<GalaxyGeneration>().TailsVector;
        SpawnPoint = this.gameObject;
        //transform.RotateAround(Star.transform.position, Vector3.up, a * Time.deltaTime);
    }

     void SpawnStars ()
    {
        //������ ������ �� ����� ������. �������� ���������� ����������� ����. ������� ������, �� �������� ����� �������������. ����������.
        Instantiate(Star, SpawnPoint.transform.position, Quaternion.identity);
        SpawnCount--;
        SpawnPoint.transform.position = new Vector3 (SpawnPoint.transform.position.x + SpawnRange, 0, 0);
    }

    void Update()
    {
        if (SpawnCount > 0)
        {
            SpawnStars();
        }
        else 
        {
            Stars = GameObject.FindGameObjectsWithTag("Star");
        }
    }
}
 