using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsSpawn : MonoBehaviour
{
    GameObject Spawn;
    public GameObject Planet;
    public int MinChanceSpawn = 50;//����������� ���� ������
    public int ChanceSpawn;//���� ������

    void Awake()
    {
        ChanceSpawn = Random.Range(0, 100);
    }

    void Start()
    {
        Spawn = this.gameObject;
        if (ChanceSpawn > MinChanceSpawn) 
        {
            Instantiate(Planet, Spawn.transform.position, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
