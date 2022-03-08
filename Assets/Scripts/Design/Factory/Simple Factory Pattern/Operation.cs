using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation
{
    private double _numA = 0;
    private double _numB = 0;

    public double NumA
    {
        get { return _numA; }
        set { _numA = value; }
    }

    public double NumB
    {
        get { return _numB; }
        set { _numB = value; }
    }

    public virtual double GetResult()
    {
        double result = 0;
        return result;
    }

}
