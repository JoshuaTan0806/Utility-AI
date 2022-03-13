using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStats : MonoBehaviour
{
    public List<Stat> stats = new List<Stat>();
    public Transform Location;

    private void Awake()
    {
        for (int i = 0; i < StatManager.instance.Stats.Count; i++)
        {
            StatManager.instance.Stats[i].RandomiseStat();
            stats.Add(Instantiate(StatManager.instance.Stats[i]));
        }
    }

    public Stat FindStat(Stat stat)
    {
        for (int i = 0; i < stats.Count; i++)
        {
            if (stat.Name == stats[i].Name)
                return stats[i];
        }

        return null;
    }

    public bool IsAtLocation(Location location)
    {
        if (Location == null)
            return false;

        Location[] locations = Location.GetComponent<AddLocation>().Locations;

        for (int i = 0; i < locations.Length; i++)
        {
            if (locations[i] == location)
                return true;
        }

        return false; 
    }
}
