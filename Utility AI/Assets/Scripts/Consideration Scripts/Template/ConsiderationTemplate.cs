using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConsiderationTemplate", menuName = "Utility AI/Consideration/ConsiderationTemplate")]
public class ConsiderationTemplate : Consideration
{
    public override float ScoreConsideration(AIStats stats)
    {
        return base.ScoreConsideration(stats);
    }
}
