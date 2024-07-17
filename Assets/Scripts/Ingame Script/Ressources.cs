using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ressources : MonoBehaviour
{
    private Warehouse warehouse;

    // UI elements
    public TMP_Text moraleText;
    public TMP_Text workforceText;
    public TMP_Text goldText;
    public TMP_Text foodText;

    void Start()
    {
        warehouse = FindObjectOfType<Warehouse>();

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
