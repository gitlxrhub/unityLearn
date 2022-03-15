﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using Object = System.Object;

public class BaseClone<T> 
{
    public static T DeepClone(T source)
    {

        if (!typeof(T).IsSerializable)
        {
            throw new ArgumentException("The type must be serializable.", "source");
        }
        if (Object.ReferenceEquals(source, null))
        {
            return default(T);
        }
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new MemoryStream();
        using (stream)
        {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T)formatter.Deserialize(stream);
        }
    }
}
