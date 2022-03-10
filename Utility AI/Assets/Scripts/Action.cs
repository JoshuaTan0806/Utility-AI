using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : ScriptableObject
{
    public List<Consideration> considerations;
    public List<Consequence> consequences;

    bool IsComplete;

    public virtual void InitialiseAction(AIStats stats)
    {
        IsComplete = false;
    }

    public virtual void ExecuteAction(AIStats stats)
    {

    }

    public virtual void CompleteAction(AIStats stats)
    {
        IsComplete = true;

        for (int i = 0; i < consequences.Count; i++)
        {
            consequences[i].ExecuteConsequence(stats);
        }
    }

    public virtual void AbortAction(AIStats stats)
    {
        IsComplete = true;
    }

    public virtual bool IsActionComplete()
    {
        return IsComplete;
    }

    public virtual float ScoreAction(AIStats stats)
    {
        for (int i = 0; i < considerations.Count; i++)
        {
            considerations[i].ScoreConsideration(stats);
        }

        return 0;
    }
}
