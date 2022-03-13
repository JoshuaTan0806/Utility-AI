using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveToLocationAction", menuName = "Utility AI/Actions/MoveToLocationAction")]
public class MoveToLocationAction : Action
{
    public Location Location;
    Transform destination;
    
    public override void InitialiseAction(AIStats stats)
    {
        base.InitialiseAction(stats);
        stats.Location = null;
        destination = stats.FindClosestLocation(Location);
    }

    public override void ExecuteAction(AIStats stats)
    {
        stats.transform.position = Vector3.MoveTowards(stats.transform.position, destination.position, Time.deltaTime);
    }

    public override void CompleteAction(AIStats stats)
    {
        base.CompleteAction(stats);
        stats.Location = destination;
    }

    public override bool IsConditionMet(AIStats stats)
    {
        return stats.transform.position == destination.position;
    }

    public override float ScoreAction(AIStats stats)
    {
        if (stats.IsAtLocation(Location))
            return 0;

        return base.ScoreAction(stats);
    }
}
