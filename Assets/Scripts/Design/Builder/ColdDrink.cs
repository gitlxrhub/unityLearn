using System;
using UnityEngine;

public abstract class ColdDrink : IFoodItem
{
    public abstract string Name();

    public  IPacking Packing()
    {
        return new Bottle();
    }

    public abstract float Price();
}
