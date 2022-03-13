using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ModifyInventoryConsequence", menuName = "Utility AI/Consequences/ModifyInventoryConsequence")]
public class ModifyInventoryConsequence : Consequence
{
    public Item Item;

    public Types Type;
    public enum Types
    {
        AddItem,
        RemoveItem
    }

    public override void ExecuteConsequence(AIStats stats)
    {
        if (Type == Types.AddItem)
            stats.GetComponent<Inventory>().AddItem(Item);
        else if(Type == Types.RemoveItem)
            stats.GetComponent<Inventory>().RemoveItem(Item);
    }
}
