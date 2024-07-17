using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{

    public BuildManager buildManager;

    // Start is called before the first frame update
    void Start()
    {
        // Example of creating a new building at runtime
        Building newBuilding = ScriptableObject.CreateInstance<Building>();
        newBuilding.name = "New Farm";
        newBuilding.ProduceAmountFood = 10;

        // Add the new building to the BuildManager 
        buildManager.AddBuilding(newBuilding);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
