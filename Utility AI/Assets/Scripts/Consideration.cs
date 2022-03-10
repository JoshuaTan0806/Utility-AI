using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consideration : ScriptableObject
{
    public virtual float ScoreConsideration(AIStats stats)
    {
        return 0;
    }
}
