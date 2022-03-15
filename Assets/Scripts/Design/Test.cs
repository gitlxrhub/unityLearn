using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        #region 单例模式
        //不合法的构造函数
        //编译时错误：构造函数 SingleObject() 是不可见的
        //SingleObject singleObject = new SingleObject();
        //singleObject.ShowMessage();
        SingleObject singleObject = SingleObject.GetInstance();
        singleObject.ShowMessage();
        #endregion
        */

        /*
        #region 简单工厂模式
        Operation oper = OperationFactory.createOperate("+");
        oper.NumA = 0.1;
        oper.NumB = 0.2;
        double res = oper.GetResult();
        Debug.Log("计算后："+ res);
        #endregion
        */

        /*
        #region 工厂方法模式
        //生产工作流程
        //客户要产品A
        FactoryA mFactoryA = new FactoryA();
        mFactoryA.Manufacture().Show();

        //客户要产品B
        FactoryB mFactoryB = new FactoryB();
        mFactoryB.Manufacture().Show();
        #endregion
        */

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


        /*
        #region 建造者模式
        MealBuilder mealBuilder = new MealBuilder();
        Meal packageA = mealBuilder.PackageA();
        packageA.ShowItems();
        Debug.Log("套餐A"+ packageA.GetCost());
        #endregion
        */

        /*
        #region
        Person p = new Person() { Name = "P", Age = 21 };
        Person p1 = p; // 这就是浅拷贝
        Person p2 = BaseClone<Person>.DeepClone(p);
        string Str = string.Format("修改前：p.Name={0},p.Age={1}", p.Name, p.Age);
        Debug.Log(Str);
        Str = string.Format("修改前：p1.Name={0},p1.Age={1}", p1.Name, p1.Age);
        Debug.Log("p2" + p2);
        Debug.Log(Str);
        Str = string.Format("修改前：p2.Name={0},p2.Age={1}", p2.Name, p2.Age);
        Debug.Log(Str);

        //修改P1的值
        p1.Name = "PM";
        p1.Age = 30;


        Str = string.Format("修改后：p.Name={0},p.Age={1}", p.Name, p.Age);
        Debug.Log(Str);
        Str = string.Format("修改后：p1.Name={0},p1.Age={1}", p1.Name, p1.Age);
        Debug.Log(Str);
        Str = string.Format("修改后：p2.Name={0},p2.Age={1}", p2.Name, p2.Age);
        Debug.Log(Str);


        #endregion
        */
    }

}
