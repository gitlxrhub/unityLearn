using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShangHaiFactory : AbstractFactory
{
    public ShangHaiFactory()
    {
        Debug.Log("上海厂家--值得信赖");
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
