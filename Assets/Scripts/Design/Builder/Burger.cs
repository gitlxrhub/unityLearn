using System;
public abstract class Burger : IFoodItem
{
    public abstract string Name();

    public IPacking Packing()
    {
        return new Wrapper();
    }

    public abstract float Price();
}
