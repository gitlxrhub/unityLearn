using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proxy : Subject
{
    RealSubject realSubject;
    public override void Request()
    {
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }
        realSubject.Request();
    }

}
