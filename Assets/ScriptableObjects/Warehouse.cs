using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;


[CreateAssetMenu(fileName ="New Warehouse",menuName ="Warehouse")]
public class Warehouse : ScriptableObject
{
    [SerializeField] int food;
    [SerializeField] int gold;
    [SerializeField] int workforce;
    [SerializeField] int morale;

    [SerializeField] int farmNumber;
    [SerializeField] int houseNumber;
    [SerializeField] int capitalBuildingNumber;

    public int Food { get => food; set => food = value; }
    public int Gold { get => gold; set => gold = value; }
    public int Workforce { get => workforce; set => workforce = value; }
    public int FarmNumber { get => farmNumber; set => farmNumber = value; }
    public int HouseNumber { get => houseNumber; set => houseNumber = value; }
    public int CapitalBuildingNumber { get => capitalBuildingNumber; set => capitalBuildingNumber = value; }

    public int Morale { get => morale; set => morale = value; }

}
