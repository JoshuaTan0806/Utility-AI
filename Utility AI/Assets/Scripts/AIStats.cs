using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class AIStats : MonoBehaviour
{
    public List<Stat> stats = new List<Stat>();
    public Transform Location;
    [HideInInspector] public Inventory Inventory;

    private void Awake()
    {
        for (int i = 0; i < StatManager.instance.Stats.Count; i++)
        {
            StatManager.instance.Stats[i].RandomiseStat();
            stats.Add(Instantiate(StatManager.instance.Stats[i]));
        }

        Inventory = GetComponent<Inventory>();
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

    public Transform FindClosestLocation(Location location)
    {
        if (LocationManager.instance.locations[location] == null)
            return null;

        float ClosestDistance = Mathf.Infinity;
        Transform ClosestTransform = null;

        for (int i = 0; i < LocationManager.instance.locations[location].Count; i++)
        {
            float Distance = Vector3.Distance(transform.position, LocationManager.instance.locations[location][i].position);

            if (Distance < ClosestDistance)
            {
                ClosestDistance = Distance;
                ClosestTransform = LocationManager.instance.locations[location][i];
            }
        }

        return ClosestTransform;
    }
}
