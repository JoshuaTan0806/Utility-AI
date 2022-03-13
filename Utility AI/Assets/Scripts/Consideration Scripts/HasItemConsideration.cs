using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HasItemConsideration", menuName = "Utility AI/Considerations/HasItemConsideration")]
public class HasItemConsideration : Consideration
{
    public Item Item;

    public override float ScoreConsideration(AIStats stats)
    {
        return stats.Inventory.HasItem(Item) ? 1 : 0;
    }
}
