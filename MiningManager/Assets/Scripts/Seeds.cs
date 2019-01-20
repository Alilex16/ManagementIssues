using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Seed", menuName = "Seeds")]
public class Seeds : ScriptableObject
{
    public string seedName;
    public string seedDescription;
    public int seedValue;

    public Sprite seedSprite; //growthStages
    
    public float plantingTime;
    public float growingTime;
    public float harvestingTime;
    
    public int harvestAmount;
}
