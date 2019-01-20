using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EmployeePool : MonoBehaviour
{
    private const int _minimumForHire = 5;
    public static EmployeePool Instance;
    private List<Employee> HiredEmployees { get; set; }
    private List<Employee> EmployeesForHire { get; set; }


    void Start()
    {
        if (Instance != null)

        {
            throw new InvalidProgramException("This class should only be present once in the solution.");
        }
        Instance = this;

        Initialize();
        RefillHiringPool();
    }

    private void Initialize()
    {
        this.HiredEmployees = new List<Employee>();
        this.EmployeesForHire = new List<Employee>();
    }


    void Update()

    {
        RefillHiringPool();
    }

    private void RefillHiringPool()
    {
        if (EmployeesForHire.Count < _minimumForHire)
        {
            EmployeesForHire.Add(EmployeeFactory.Create());
        }
    }


    public void FireEmployee(Guid id)
    {
        var fired = HiredEmployees.FirstOrDefault(e => e.Id == id);
        HiredEmployees.Remove(fired);
    }


    public void HireEmployee(Guid id)
    {
        var hired = EmployeesForHire.FirstOrDefault(e => e.Id == id);
        EmployeesForHire.Remove(hired);
        HiredEmployees.Add(hired);
        EmployeePool.Instance.GetRouteCount();
    }

    public Dictionary<Routes, int> GetRouteCount()
    {
        var routeCount = new Dictionary<Routes, int>();
        foreach (var employee in HiredEmployees)
        {
            if (!routeCount.ContainsKey(employee.CurrentRoute))
            {
                routeCount.Add(employee.CurrentRoute, 1);
            }
            else
            {
                routeCount[employee.CurrentRoute] += 1;
            }
        }
        return routeCount;
    }
}



public static class EmployeeFactory
{
    private static MyRandomizer randomizer = new MyRandomizer();
    
    public static Employee Create()
    {
        var result = new Employee
        {
            employeeName = randomizer.SelectName().ToString(),
            description = randomizer.SelectDescription().ToString()
        };
        return result;
    }
}

public class Routes
{
    enum Route
    {
        None,
        etc,
        
    }
}

internal class MyRandomizer
{
    internal object SelectDescription()
    {
        throw new NotImplementedException();
    }

    internal object SelectName()
    {
        throw new NotImplementedException();
    }
}

