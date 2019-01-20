using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

[CreateAssetMenu(fileName = "TierList", menuName = "Item")]
public class TierList : ScriptableObject
{
    public string itemName;
    public string itemDescription;

    public Sprite itemIcon;

    public Sprite itemReq01Icon;
    public Sprite itemReq02Icon;
    
    public int itemReq01Amount;
    public int itemReq02Amount;

    public int tierRank;

}
