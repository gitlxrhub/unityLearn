using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealSubject : Subject
{
    public override void Request()
    {
        Debug.Log("真实请求中...");
    }
}
