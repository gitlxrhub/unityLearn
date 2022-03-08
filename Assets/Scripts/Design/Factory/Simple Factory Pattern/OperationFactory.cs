using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * 
 * 简单工厂模式
 * 
 * **/
public class OperationFactory
{
    public static Operation createOperate(string operate)
    {
        Operation oper = null;
        switch (operate)
        {
            case "+":
                oper = new OperationAdd();
                break;
            case "-":
                oper = new OperationSub();
                break;
        }
        return oper;
    }
}
