using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationAdd : Operation
{
    public override double GetResult()
    {
        return NumA + NumB;
    }
}
