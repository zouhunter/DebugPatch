using UnityEngine;
using System;

public sealed class Debug
{
    public static void Log(object message)
    {
        UnityEngine.Debug.Log(System.DateTime.Now.ToString("DD:HH:mm:ss") + ":" + message);
    }
}

