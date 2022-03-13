using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IsStatHigherConsideration", menuName = "Utility AI/Considerations/IsStatHigherConsideration")]
public class IsStatHigherConsideration : Consideration
{
    public Stat Stat;
    public AnimationCurve AnimationCurve;

    public override float ScoreConsideration(AIStats stats)
    {
        return AnimationCurve.Evaluate(stats.FindStat(Stat).Value / 100);
    }
}
