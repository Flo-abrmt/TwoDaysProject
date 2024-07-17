using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    CycleController cycleController;

    private void Start()
    {
        cycleController = GetComponent<CycleController>();
        startCityCycle();
    }

    //load data of Player and Game
    public void LoadData()
    {

    } 
    //diverse the day in different phases
    //after each day the cycle will restart
    void startCityCycle()
    {
        cycleController.handleCycle();
    }
}
