using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuaWeiProduct : AbstractHuaWeiProduct
{
    public HuaWeiProduct() {
        Debug.Log("欢迎光临 -- 华为");
    }
    public override void Phone()
    {
        base.Phone();
    }

    public override void Pad()
    {
        base.Pad();
    }

    public override void Watch()
    {
        base.Watch();
    }
}
