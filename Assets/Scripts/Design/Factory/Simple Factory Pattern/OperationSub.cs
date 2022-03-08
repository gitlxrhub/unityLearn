using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationSub : Operation
{
    public override double GetResult()
    {
        return NumA - NumB;
    }
}
