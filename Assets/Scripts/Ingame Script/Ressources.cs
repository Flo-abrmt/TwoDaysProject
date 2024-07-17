using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
//using System.Threading;
using System.Timers;

public class Ressources : MonoBehaviour
{
  // Resource values
    private int morale = 50;
    private int workforce = 20;
    private int gold = 100;
    private int food = 100;
    private Timer aTimer = new System.Timers.Timer(15000);

    // UI elements
    public TMP_Text moraleText;
    public TMP_Text workforceText;
    public TMP_Text goldText;
    public TMP_Text foodText;

    void Start()
    {

        // // Initialize the UI with the starting values
        // Thread thread = new Thread(UpdateResourceUI());

        // thread.Start();

        // thread.Sleep(10000);

        // Hook up the Elapsed event for the timer. 
        UpdateResourceUI();
    }

    // Method to update the UI elements with the current values
    void UpdateResourceUI()
    {
        morale =+ 0;
        workforce =+ 1;
        gold =+ 1;
        food =+ 1;


        moraleText.text = $"{morale} / 100";
        workforceText.text = workforce.ToString();
        goldText.text = gold.ToString();
        foodText.text = food.ToString();
        
    }

    // Methods to modify resource values (examples)
    public void IncreaseMorale(int amount)
    {
        morale = Mathf.Clamp(morale + amount, 0, 100);
        UpdateResourceUI();
    }

    public void DecreaseMorale(int amount)
    {
        morale = Mathf.Clamp(morale - amount, 0, 100);
        UpdateResourceUI();
    }

    public void IncreaseWorkforce(int amount)
    {
        workforce += amount;
        UpdateResourceUI();
    }

    public void DecreaseWorkforce(int amount)
    {
        workforce -= amount;
        UpdateResourceUI();
    }

    public void IncreaseGold(int amount)
    {
        gold += amount;
        UpdateResourceUI();
    }

    public void DecreaseGold(int amount)
    {
        gold -= amount;
        UpdateResourceUI();
    }

    public void IncreaseFood(int amount)
    {
        food += amount;
        UpdateResourceUI();
    }

    public void DecreaseFood(int amount)
    {
        food -= amount;
        UpdateResourceUI();
    }
}
