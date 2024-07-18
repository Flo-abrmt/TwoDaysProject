using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public List<Building> buildings = new List<Building>();
    [SerializeField]
    public Warehouse warehouse;

    void Start()
    {
        Debug.Log("start Buildmanager");
        LoadBuildings();
        StartProducingResources();
    }

    private void LoadBuildings()
    {
        Debug.Log("Load all buildings");
        try
        {
            // Load all Building ScriptableObjects from the Resources/Buildings folder
            Building[] loadedBuildings = Resources.LoadAll<Building>("Buildings");
            // Add each loaded Building to the buildings list
            foreach (Building building in loadedBuildings)
            {
                buildings.Add(building);
            }

        }
        catch (Exception e)
        {
            Debug.LogError(e.ToString());
            throw e;

        }
    }

    private void StartProducingResources()
    {

        Debug.Log("Start Processing Ress");
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
