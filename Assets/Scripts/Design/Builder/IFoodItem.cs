using System;
public interface IFoodItem
{
    public string Name();
    public IPacking Packing();
    public float Price();
}
