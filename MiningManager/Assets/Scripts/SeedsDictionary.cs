using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedsDictionary : MonoBehaviour
{

    public string seedName;
    public int seedSomething;

    public SeedsDictionary(string newName, int newPower)
    {
        seedName = newName;
        seedSomething = newPower;
    }


    private void Start()
    {
        Dictionary<string, SeedsDictionary> badguys = new Dictionary<string, SeedsDictionary>();

        SeedsDictionary bg1 = new SeedsDictionary("Harvey", 50);
        SeedsDictionary bg2 = new SeedsDictionary("Magneto", 100);

        badguys.Add("Strawberry Seed", bg1);
        badguys.Add("mutant", bg2);

        SeedsDictionary magneto = badguys["mutant"];

        SeedsDictionary temp = null;

        if (badguys.TryGetValue("birds", out temp))
        {
            //success!
        }
        else
        {
            //failure!
        }
    }
}
