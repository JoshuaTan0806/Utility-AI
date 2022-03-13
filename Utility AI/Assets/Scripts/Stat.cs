using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stat", menuName = "Utility AI/Stat")]
public class Stat : ScriptableObject
{
    public string Name;
    public float Value;

    public void RandomiseStat()
    {
        Value = Random.Range(0, 100);
    }
}
