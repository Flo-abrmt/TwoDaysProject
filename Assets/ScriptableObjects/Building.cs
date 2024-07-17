using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New building",menuName ="Building")]
public class Building : ScriptableObject {

    [SerializeField] string description;
    [SerializeField] string buildCostWorkForce;
    [SerializeField] int? buildCostsWorkForce;
    [SerializeField] string buildCostFood;
    [SerializeField] int? buildCostsFood;
    [SerializeField] string buildCostGold;
    [SerializeField] int? buildCostsGold;
    [SerializeField] string buildName;
    [SerializeField] int? importance;
    [SerializeField] string produceWorkForce;
    [SerializeField] int? produceAmountWorkForce;
    [SerializeField] string produceFood;
    [SerializeField] int? produceAmountFood;
    [SerializeField] string produceGold;
    [SerializeField] int? produceAmountGold;
    [SerializeField] int? buildtime;

    [SerializeField] List<string> additionalInformations;

    [SerializeField] Sprite UISprite;
    [SerializeField] Sprite GameSprite;




    private void Awake()
    {
        
    }
}




