using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New building", menuName = "Building")]
public class Building : ScriptableObject
{
    [SerializeField] private string description;
    [SerializeField] private int buildCostsWorkForce;
    [SerializeField] private int buildCostsFood;
    [SerializeField] private int buildCostsGold;
    [SerializeField] private string buildName;
    [SerializeField] private int importance;
    [SerializeField] private int produceAmountWorkForce;
    [SerializeField] private int produceAmountFood;
    [SerializeField] private int produceAmountGold;
    [SerializeField] private int buildtime;
    [SerializeField] private float producetime = 12;

    [SerializeField] private List<string> additionalInformations;

    [SerializeField] public Sprite UISprite;
    [SerializeField] public Sprite GameSprite;

    public string BuildName => buildName;
    public int ProduceAmountFood { get => produceAmountFood; set => produceAmountFood = value; }
    public int ProduceAmountGold { get => produceAmountGold; set => produceAmountGold = value; }
    public int ProduceAmountWorkForce { get => produceAmountWorkForce; set => produceAmountWorkForce = value; }

    public void StartProducing(MonoBehaviour host, Warehouse warehouse)
    {
        host.StartCoroutine(ProduceResources(warehouse));
    }

    private IEnumerator ProduceResources(Warehouse warehouse)
    {
        while (true)
        {
            yield return new WaitForSeconds(producetime); // Every 12 seconds

            if (produceAmountFood > 0)
            {
                warehouse.Food += produceAmountFood;
            }
            if (produceAmountGold > 0)
            {
                warehouse.Gold += produceAmountGold;
            }
            if (produceAmountWorkForce > 0)
            {
                warehouse.Workforce += produceAmountWorkForce;
            }

            Debug.Log($"Updated Warehouse: Food={warehouse.Food}, Gold={warehouse.Gold}, Workforce={warehouse.Workforce}");
        }
    }
}
