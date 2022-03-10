using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLocation : MonoBehaviour
{
    public Location[] Locations;

    // Start is called before the first frame update
    void Start()
    {
        AddToLocationManager();    
    }

    public void AddToLocationManager()
    {
        for (int i = 0; i < Locations.Length; i++)
        {
            if (!LocationManager.instance.locations.ContainsKey(Locations[i]))
            {
                List<Transform> List = new List<Transform>();
                List.Add(transform);
                LocationManager.instance.locations.Add(Locations[i], List);
            }
            else
            {
                LocationManager.instance.locations[Locations[i]].Add(transform);
            }
        }
    }
}
