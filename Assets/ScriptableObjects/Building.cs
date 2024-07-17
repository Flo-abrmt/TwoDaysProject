using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New building",menuName ="Building")]
public class Building : ScriptableObject {

    [SerializeField] string description;
    [SerializeField] string costWorkForce;
    [SerializeField] int? costsWorkForce;
    [SerializeField] string costFood;
    [SerializeField] int? costsFood;
    [SerializeField] string costGold;
    [SerializeField] int? costsGold;
    [SerializeField] string buildName;
    [SerializeField] int? importance;
    [SerializeField] string produceWorkForce;
    [SerializeField] int? produceAmountWorkForce;
    [SerializeField] string produceFood;
    [SerializeField] int? produceAmountFood;
    [SerializeField] string produceGold;
    [SerializeField] int? produceAmountGold;

    [SerializeField] List<string> additionalInformations;

    [SerializeField] Sprite UISprite;
    [SerializeField] Sprite GameSprite;
}




