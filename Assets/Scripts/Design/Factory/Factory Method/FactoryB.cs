using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryB : Factory
{
    public override Product Manufacture()
    {
        return new ProductB();
    }
}
