using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityController : MonoBehaviour
{
 
    [SerializeField] Warehouse cityWarehouse;

    void whenInitialized()
    {

    }

    public void whenCycle()
    {
        Debug.Log("123");
        Debug.Log(cityWarehouse.Food);
    }

    void checkForRessources()
    {

    }

    void buildBuildings()
    {

    }
    //function get called all cycles

    //function to get the ressources and safe them into an array

    //function to let the city make things if ressources are high enogh


}
