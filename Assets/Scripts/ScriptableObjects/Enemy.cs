using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ScriptableObject
{
    public int HP;
    public int MAXHP;
    public int Attack;
    public int Defense;
    // The level determines the ammount of star points you will earn from the battle, if the enemy level is below or equal to your level, you will never earn any star points
    public int Level;
    public enum Attributes
    { Ground, Spiked, TopSpiked, Elevated, FLying, Fire, Cloud, Electric, Cieling}

    //What is the point of having seperate "Spiked" Sections when you can't even jump on spiked enemies?  Well, Those pokeys also have spikes on their sides//
    

    public enum Weakness {Fire, Ice, Electric, Explosion, Star, Water, Piercing}
    public enum Immunity {Fire, Ice, Electric, Explosion, Star, Water, Piercing}

}

