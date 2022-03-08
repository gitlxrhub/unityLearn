using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractAppleProduct : IElectronic
{
    public virtual void Pad()
    {
        Debug.Log("苹果系列--Pad");
    }

    public virtual void Phone()
    {
        Debug.Log("苹果系列--Phone");
    }

    public virtual void Watch()
    {
        Debug.Log("苹果系列--Watch");
    }

    public virtual void AirTag() {
        Debug.Log("苹果系列--AirTag(华为没有的哦)");
    }
}
