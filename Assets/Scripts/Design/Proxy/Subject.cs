using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 代理模式(Proxy Pattern)
 * 代理模式，为其它对象提供一种代理以控制对这个对象的访问。换句话说就是给某一个对象提供一个代理，并由代理对象控制对原对象的引用。
 * 在一些情况下，一个客户端不想或者不能直接引用一个对象，而代理对象可以在客户端和目标对象之间起到中介的作用。
 * 例如电脑桌面的快捷方式就是一个代理对象，快捷方式是它所引用的程序的一个代理。
 * **/
public abstract class Subject
{
    public abstract void Request();
}
