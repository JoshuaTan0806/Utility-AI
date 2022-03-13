using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaitAction", menuName = "Utility AI/Actions/WaitAction")]
public class WaitAction : Action
{
    public float TimeToWait;
    float CurrentTimeToWait;

    public override void InitialiseAction(AIStats stats)
    {
        base.InitialiseAction(stats);
        CurrentTimeToWait = TimeToWait;
    }

    public override void ExecuteAction(AIStats stats)
    {
        base.ExecuteAction(stats);
        CurrentTimeToWait -= Time.deltaTime;
    }

    public override bool IsConditionMet(AIStats stats)
    {
        return CurrentTimeToWait < 0;
    }
}
