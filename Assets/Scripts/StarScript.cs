using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    public int Modify1;//����������� 1
    public int Modify2;//����������� 2
    public int Modify3;//����������� 3
    public GameObject Star;




    public static string[,] PlanetTips = new string[,] { //������ � ������ ����
        { "Proto-Star", "White Dwarf", "Brown Dwarf", "Red Dwarf", "Red Giant", "A T-type Taurus star" },
        { "Blue Star", "White Star", "Yellow Star", "Red Supergiant", "Double Star", "" },
        { "Transparent Star", "Quasar", "Cepheid", "Neutron Star", "Collapsing Star", ""},
        };

    void Start()
    {
        Star = this.gameObject;
    }

    void Update()
    {
        
    }
}
