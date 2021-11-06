using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetComposition : MonoBehaviour
{
    public int PlanetID;//ID �������
    public float PlanetSize = 1;//������ ������� (�� 1 �� 5) (����������� ������) 
    public int PlanetTemperature;//����������� ������� (�� 1 �� 6, ��� 1 ��� ��, � 6 ��� �����) 
    public int PlanetHumidity;//��������� (�� 1 �� 5, ��� 1 ��� �����, � 5 ��� ���) 
    public string PlanetType;//��� �������
    public GameObject Planet; 
    public int RotateSpeed;
    public GameObject[] Stars;//������ � �������
    public GameObject Star;//������ � ������� ������������� �������

    public static string[,] PlanetTips = new string[,] { //������ � ������ ������
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
