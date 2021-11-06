using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class StarMapGeneration : MonoBehaviour
{
    public GameObject Star;
    public int SpawnRange = 20;//Расстояние спавна от другой звезды
    public int SpawnCount = 1;//Количество спавна звёзд
    private GameObject SpawnPoint;//Этот объект
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
        //Создаём звезду на точке спавна. Убавляем количество спавнящихся звёзд. Спавним объект, от которого будем отталкиваться. Уничтожаем.
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
 