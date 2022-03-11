using System;
public class MealBuilder
{
    public Meal PackageA()
    {
        Meal meal = new Meal();
        meal.AddItem(new VegBurger());
        meal.AddItem(new Coke());
        return meal;
    }

    public Meal PackageB()
    {
        Meal meal = new Meal();
        meal.AddItem(new ChickenBurger());
        meal.AddItem(new Coke());
        return meal;
    }

    public Meal PackageC()
    {
        Meal meal = new Meal();
        meal.AddItem(new ChickenBurger());
        meal.AddItem(new Pepsi());
        return meal;
    }

    public Meal PackageD()
    {
        Meal meal = new Meal();
        meal.AddItem(new VegBurger());
        meal.AddItem(new Pepsi());
        return meal;
    }
}
