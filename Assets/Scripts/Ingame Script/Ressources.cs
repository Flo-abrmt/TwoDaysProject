using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ressources : MonoBehaviour
{
    public Warehouse warehouse;

    // UI elements
    public TMP_Text moraleText;
    public TMP_Text workforceText;
    public TMP_Text goldText;
    public TMP_Text foodText;

    void Start()
    {

        if (warehouse == null)
        {
            Debug.LogError("Warehouse not found!");
            return;
        }

        // Subscribe to the warehouse's resource update event
        warehouse.onResourcesUpdated += UpdateResourceUI;

        // Initialize the UI with the starting values
        UpdateResourceUI();

    }

    void UpdateResourceUI()
    {
        Debug.Log("Update UI values in Resource.cs");
        moraleText.text = $"{warehouse.Morale} / 100";
        workforceText.text = warehouse.Workforce.ToString();
        goldText.text = warehouse.Gold.ToString();
        foodText.text = warehouse.Food.ToString();
    }

    void OnDestroy()
    {
        if (warehouse != null)
        {
            warehouse.onResourcesUpdated -= UpdateResourceUI;
        }
    }
}
