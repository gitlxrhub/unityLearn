using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleObject
{
    private static SingleObject instance = new SingleObject();

    //让构造函数为 private，这样该类就不会被实例化
    private SingleObject() { }

    public static SingleObject GetInstance() {
        return instance;
    }

    public void ShowMessage()
    {
        Debug.Log("单例模式跑起来");
    }

}
