using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IsAtLocationConsideration", menuName = "Utility AI/Considerations/IsAtLocationConsideration")]
public class IsAtLocationConsideration : Consideration
{
    public Location Location;

    public override float ScoreConsideration(AIStats stats)
    {
        return stats.IsAtLocation(Location) ? 1 : 0;
    }
}
