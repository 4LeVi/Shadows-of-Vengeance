using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetComposition : MonoBehaviour
{
    public int PlanetID;//ID планеты
    public float PlanetSize = 1;//Размер планеты (от 1 до 5) (независимый размер) 
    public int PlanetTemperature;//Температура планеты (от 1 до 6, где 1 это лёд, а 6 это огонь) 
    public int PlanetHumidity;//Влажность (от 1 до 5, где 1 это сухая, а 5 это газ) 
    public string PlanetType;//Тип планеты
    public GameObject Planet; 
    public int RotateSpeed;
    public GameObject[] Stars;//Массив с звёздами
    public GameObject Star;//Звезда к которой привязывается планета

    public static string[,] PlanetTips = new string[,] { //Массив с типами планет
        { "Barren", "Arctic", "Steppes", "Arid", "Desert", "Ash" }, 
        { "Snow", "Tundra", "Terran", "Veldt", "Tropical", "" },
        { "", "Boreal", "Forest", "Swamp", "Jungle", "Lava"},
        { "Ice", "", "Ocean", "", "Atoll", "" },
        {"Gas1", "Gas2", "Gas3", "Gas4", "Gas5", "Gas6" }
    };

    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(Star.transform.position, Vector3.up, RotateSpeed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.X)) 
        {
            PlanetRandomisation();
        }


    }
    void OnEnable() 
    {
        Stars = GameObject.FindGameObjectsWithTag("Star");
        Star = Stars[Stars.Length-1];
        RotateSpeed = Random.Range(1, 50);
        Planet = this.gameObject;
        PlanetRandomisation();
    }
    void PlanetRandomisation()
    {
        PlanetSize = Mathf.RoundToInt(Random.Range(1, 5));
        Planet.transform.localScale = new Vector3(PlanetSize, PlanetSize, PlanetSize);
        PlanetTemperature = Random.Range(0, 5);
        PlanetHumidity = Random.Range(0, 4);
        PlanetType = PlanetTips[PlanetHumidity, PlanetTemperature];
    }
}
