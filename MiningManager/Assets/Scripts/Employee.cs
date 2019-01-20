using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

[CreateAssetMenu(fileName = "New Employee", menuName = "Employees")]
public class Employee : ScriptableObject
{
    public string employeeName;
    public string description;

    public int employeeNumber;

    public Sprite artwork;

    public int fatigue;
    public int speed;
    public int strength;
    public int salary; //this is calculated
    public string specialty; //int??
    public string route;

    public Guid Id { get; internal set; } //
    public Routes CurrentRoute { get; internal set; } //
}
