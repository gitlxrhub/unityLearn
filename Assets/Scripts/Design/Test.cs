using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        #region  工厂模式测试
        AbstractFactory Factory = null;
        Factory = new ShangHaiFactory();
        AppleProduct apple = (AppleProduct)Factory.CreatorApple();
        apple.Pad();
        apple.Phone();
        apple.AirTag();

        Factory = new ShenZhenFactory();
        HuaWeiProduct huawei = (HuaWeiProduct)Factory.CreatorHuaWei();
        huawei.Watch();
        #endregion
        */

        #region 代理模式测试
        Proxy proxy = new Proxy();
        proxy.Request();
        #endregion
    }

}
