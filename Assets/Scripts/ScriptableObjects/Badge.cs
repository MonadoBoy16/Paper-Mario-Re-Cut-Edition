using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Badge", menuName = "Badges")]

public class Badge : ScriptableObject
{
    public new string name;
    // The description will only be used in the badge equip menu
    public string description;

    public Sprite badge;

    // Determines the BP Cost of the Badge (Returning Badges will have their BP Cost Halved)
    public int BPCost;
    
    
}


