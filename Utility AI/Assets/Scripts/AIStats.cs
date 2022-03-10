using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStats : MonoBehaviour
{
    public List<Stat> stats = new List<Stat>();

    private void Awake()
    {
        for (int i = 0; i < StatManager.instance.Stats.Count; i++)
        {
            stats.Add(Instantiate(StatManager.instance.Stats[i]));
        }
    }
}
