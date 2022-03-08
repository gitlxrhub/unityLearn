using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenZhenFactory : AbstractFactory
{
    public ShenZhenFactory()
    {
        Debug.Log("深圳厂家--值得信赖");
    }

    public override AbstractAppleProduct CreatorApple()
    {
        return new AppleProduct();
    }

    public override AbstractHuaWeiProduct CreatorHuaWei()
    {
        return new HuaWeiProduct();
    }
}
