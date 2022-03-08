using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AbstractFactory Factory = null;
        Factory = new ShangHaiFactory();
        AppleProduct apple = (AppleProduct)Factory.CreatorApple();
        apple.Pad();
        apple.Phone();
        apple.AirTag();

        Factory = new ShenZhenFactory();
        HuaWeiProduct huawei = (HuaWeiProduct)Factory.CreatorHuaWei();
        huawei.Watch();
    }

}
