using System;
using System.Collections.Generic;
using UnityEngine;

public class Meal
{
    public List<IFoodItem> foodItems = new List<IFoodItem>();

    public void AddItem(IFoodItem item)
    {
        foodItems.Add(item);
    }

    public float GetCost() {
        float cost = 0.0f;

        foreach (IFoodItem item in foodItems)
        {
            cost += item.Price();
        }
        return cost;
    }

    public void ShowItems()
    {
        foreach (IFoodItem item in foodItems)
        {
            Debug.Log("Item : " + item.Name());
            Debug.Log("Packing : " + item.Packing().Pack());
            Debug.Log("Price : " + item.Price());
        }
    }
}
