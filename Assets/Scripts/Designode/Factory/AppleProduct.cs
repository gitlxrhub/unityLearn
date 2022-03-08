using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleProduct : AbstractAppleProduct
{
    public AppleProduct() {
        Debug.Log("欢迎光临 -- 苹果");
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
