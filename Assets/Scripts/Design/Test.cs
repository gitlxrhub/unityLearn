using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///*
        #region 简单工厂模式
        Operation oper = OperationFactory.createOperate("+");
        oper.NumA = 0.1;
        oper.NumB = 0.2;
        double res = oper.GetResult();
        Debug.Log("计算后："+ res);
        #endregion
        //*/

        #region 工厂方法模式
        //生产工作流程
        //客户要产品A
        FactoryA mFactoryA = new FactoryA();
        mFactoryA.Manufacture().Show();

        //客户要产品B
        FactoryB mFactoryB = new FactoryB();
        mFactoryB.Manufacture().Show();

        #endregion

        /*
        #region  抽象工厂模式
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

        /*
        #region 代理模式
        Proxy proxy = new Proxy();
        proxy.Request();
        #endregion
        */
    }

}
