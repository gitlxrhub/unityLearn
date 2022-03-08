using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public abstract AbstractAppleProduct CreatorApple();
    public abstract AbstractHuaWeiProduct CreatorHuaWei();
}
