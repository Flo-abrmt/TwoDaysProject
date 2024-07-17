using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public List<Building> buildings = new List<Building>();
    public Warehouse warehouse;

    void Start()
    {
        LoadBuildings();
        StartProducingResources();
    }

    private void LoadBuildings()
    {
        // Load all Building ScriptableObjects from the Resources/Buildings folder
        Building[] loadedBuildings = Resources.LoadAll<Building>("Buildings");

        // Add each loaded Building to the buildings list
        foreach (Building building in loadedBuildings)
        {
            buildings.Add(building);
        }
    }

    private void StartProducingResources()
    {
        foreach (Building building in buildings)
        {
            building.StartProducing(this, warehouse);
        }
    }

    // should be called from builder script
    public void AddBuilding(Building building)
    {
        buildings.Add(building);
        building.StartProducing(this, warehouse);
    }
}
