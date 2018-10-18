using UnityEngine;
using System;
using System.Collections.Generic;
using Object = UnityEngine.Object;

/// <summary>
/// 1.添加时间
/// 2.部分Debug
/// </summary>
public sealed class Debug
{
    private static string CurrentTime
    {
        get
        {
            return System.DateTime.Now.ToString("HH:mm:ss fff");
        }
    }
    public static ILogger logger { get { return UnityEngine.Debug.logger; } }
    public static bool developerConsoleVisible { get { return UnityEngine.Debug.developerConsoleVisible; } set { UnityEngine.Debug.developerConsoleVisible = value; } }
    public static bool isDebugBuild { get { return UnityEngine.Debug.isDebugBuild; } }
    private static List<string> ignoreTags = new List<string>();

    #region Extended
    public static void IgnoreLog(string tag)
    {
        if(!ignoreTags.Contains(tag))
        {
            ignoreTags.Add(tag);
        }
    }
    public static void UnIgnoreLog(string tag)
    {
        if (ignoreTags.Contains(tag))
        {
            ignoreTags.Remove(tag);
        }
    }
    public static string GetFullMessage(object message)
    {
        return string.Format("[{0}] {1}", CurrentTime, message);
    }

    public static void Log(object message, string tag)
    {
        if (ignoreTags.Contains(tag)) return;
        UnityEngine.Debug.Log(GetFullMessage(message));
    }

    public static void Log(object message, Object context, string tag)
    {
        if (ignoreTags.Contains(tag)) return;
        UnityEngine.Debug.Log(GetFullMessage(message), context);
    }
    public static void LogWarning(object message, Object context, string tag)
    {
        if (ignoreTags.Contains(tag)) return;
        UnityEngine.Debug.LogWarning(GetFullMessage(message), context);
    }
    public static void LogWarning(object message, string tag)
    {
        if (ignoreTags.Contains(tag)) return;

        UnityEngine.Debug.LogWarning(GetFullMessage(message));
    }

    public static void LogWarningFormat(string format, string tag, params object[] args)
    {
        if (ignoreTags.Contains(tag)) return;
        UnityEngine.Debug.LogWarningFormat(GetFullMessage(format), args);

    }
    public static void LogWarningFormat(Object context, string format, string tag, params object[] args)
    {
        if (ignoreTags.Contains(tag)) return;
        UnityEngine.Debug.LogWarningFormat(context, GetFullMessage(format), args);
    }
    #endregion

    public static void Assert(bool condition, object message, Object context)
    {
        UnityEngine.Debug.Assert(condition, GetFullMessage(message), context);
    }
    public static void Assert(bool condition, object message)
    {
        UnityEngine.Debug.Assert(condition, GetFullMessage(message));
    }
    public static void Assert(bool condition, Object context)
    {
        UnityEngine.Debug.Assert(condition, context);
    }
    public static void Assert(bool condition)
    {
        UnityEngine.Debug.Assert(condition);
    }
    public static void AssertFormat(bool condition, Object context, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, context, GetFullMessage(format), args);
    }
    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, GetFullMessage(format), args);
    }
    public static void Break()
    {
        UnityEngine.Debug.Break();
    }
    public static void ClearDeveloperConsole()
    {
        UnityEngine.Debug.ClearDeveloperConsole();
    }
    public static void DebugBreak()
    {
        UnityEngine.Debug.DebugBreak();
    }
    public static void DrawLine(Vector3 start, Vector3 end, Color color)
    {
        UnityEngine.Debug.DrawLine(start, end, color);
    }
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
    {
        UnityEngine.Debug.DrawLine(start, end, color, duration);
    }
    public static void DrawLine(Vector3 start, Vector3 end)
    {
        UnityEngine.Debug.DrawLine(start, end);
    }
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
    {
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }
    public static void DrawRay(Vector3 start, Vector3 dir,  Color color,  float duration,  bool depthTest)
    {
        UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
    }
    public static void DrawRay(Vector3 start, Vector3 dir)
    {
        UnityEngine.Debug.DrawRay(start, dir);
    }
    public static void DrawRay(Vector3 start, Vector3 dir, Color color)
    {
        UnityEngine.Debug.DrawRay(start, dir, color);
    }
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
    {
        UnityEngine.Debug.DrawRay(start, dir, color,duration);
    }
    public static void Log(object message)
    {
        UnityEngine.Debug.Log(GetFullMessage(message));
    }
    public static void Log(object message, Object context)
    {
        UnityEngine.Debug.Log(GetFullMessage(message), context);
    }
    public static void LogAssertion(object message, Object context)
    {
        UnityEngine.Debug.LogAssertion(GetFullMessage(message), context);
    }
    public static void LogAssertion(object message)
    {
        UnityEngine.Debug.LogAssertion(GetFullMessage(message));
    }
    public static void LogAssertionFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogAssertionFormat(context, GetFullMessage(format), args);
    }
    public static void LogAssertionFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogAssertionFormat(GetFullMessage(format), args);
    }
    public static void LogError(object message, Object context)
    {
        UnityEngine.Debug.LogError(GetFullMessage(message), context);
    }
    public static void LogError(object message)
    {
        UnityEngine.Debug.LogError(GetFullMessage(message));
    }
    public static void LogErrorFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(GetFullMessage(format), args);
    }
    public static void LogErrorFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(context, GetFullMessage(format), args);
    }
    public static void LogException(Exception exception)
    {
        UnityEngine.Debug.LogException(exception);
    }
    public static void LogException(Exception exception, Object context)
    {
        UnityEngine.Debug.LogException(exception,context);
    }
    public static void LogFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(context, GetFullMessage(format), args);
    }
    public static void LogFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(GetFullMessage(format), args);

    }
    public static void LogWarning(object message, Object context)
    {
        UnityEngine.Debug.LogWarning(GetFullMessage(message), context);
    }
    
    public static void LogWarning(object message)
    {
        UnityEngine.Debug.LogWarning(GetFullMessage(message));
    }
   
    public static void LogWarningFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(GetFullMessage(format), args);
    }
   
    public static void LogWarningFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(context, GetFullMessage(format), args);
    }
  
}

