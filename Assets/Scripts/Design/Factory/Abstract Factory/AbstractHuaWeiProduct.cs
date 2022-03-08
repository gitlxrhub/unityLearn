using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractHuaWeiProduct : IElectronic
{
    public virtual void Pad()
    {
        Debug.Log("华为系列--Pad");
    }

    public virtual void Phone()
    {
        Debug.Log("华为系列--Phone");
    }

    public virtual void Watch()
    {
        Debug.Log("华为系列--Watch");
    }
}
