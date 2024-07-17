using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New building",menuName ="building")]
public class Building : ScriptableObject {

    [SerializeField] string description;
    [SerializeField] string version;
    [SerializeField] string ressourceName1;
    [SerializeField] int ressourceCost1;
    [SerializeField] string ressourceName2;
    [SerializeField] int ressourceCost2;
    [SerializeField] string buildName;
    [SerializeField] int importance;

    [SerializeField] Array additionalInformations;

    [SerializeField] Sprite UISprite;
    [SerializeField] Sprite GameSprite;
}




