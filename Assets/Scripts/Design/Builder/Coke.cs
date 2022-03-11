using System;
using UnityEngine;

public class Coke : ColdDrink
{
    public override string Name()
    {
        return "Coke";
    }

    public override float Price()
    {
        return 5f;
    }
}
