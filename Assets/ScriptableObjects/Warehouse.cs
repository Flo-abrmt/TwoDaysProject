using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Warehouse", menuName = "Warehouse")]
public class Warehouse : ScriptableObject
{
    public delegate void OnResourcesUpdated();
    public event OnResourcesUpdated onResourcesUpdated;

    [SerializeField] int food;
    [SerializeField] int gold;
    [SerializeField] int workforce;
    [SerializeField] int morale;

    public int Food
    {
        get => food;
        set
        {
            food = value;
            onResourcesUpdated?.Invoke();
        }
    }

    public int Gold
    {
        get => gold;
        set
        {
            gold = value;
            onResourcesUpdated?.Invoke();
        }
    }

    public int Workforce
    {
        get => workforce;
        set
        {
            workforce = value;
            onResourcesUpdated?.Invoke();
        }
    }

    public int Morale
    {
        get => morale;
        set
        {
            morale = value;
            onResourcesUpdated?.Invoke();
        }
    }
}
