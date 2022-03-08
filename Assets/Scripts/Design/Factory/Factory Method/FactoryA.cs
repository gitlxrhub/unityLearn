using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryA : Factory
{
    public override Product Manufacture()
    {
        return new ProductA();
    }
}
