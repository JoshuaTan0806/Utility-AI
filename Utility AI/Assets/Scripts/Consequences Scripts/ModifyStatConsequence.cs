using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ModifyStatConsequence", menuName = "Utility AI/Consequences/ModifyStatConsequence")]
public class ModifyStatConsequence : Consequence
{
    public Stat Stat;

    public Types Type;
    public enum Types
    {
        SignificantlyIncrease = 20,
        GreatlyIncrease = 15,
        Increase = 10,
        SlightlyIncrease = 5,
        SlightlyDecrease = -5,
        Decrease = -10,
        GreatlyDecrease = -15,
        SignificantlyDecrease = -20,
    }

    public override void ExecuteConsequence(AIStats stats)
    {
        stats.FindStat(Stat).Value += (int)Type;
    }
}
