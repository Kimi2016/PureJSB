﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_ILogHandler
{

////////////////////// ILogHandler ///////////////////////////////////////
// constructors

// fields

// properties

// methods

static bool ILogHandler_LogException__Exception__UEObject(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Exception arg0 = (System.Exception)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.ILogHandler)vc.csObj).LogException(arg0, arg1);
    }

    return true;
}

static bool ILogHandler_LogFormat__LogType__UEObject__String__Object_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.LogType arg0 = (UnityEngine.LogType)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg2 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Object[] arg3 = JSDataExchangeMgr.GetJSArg<System.Object[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Object[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Object)JSMgr.datax.getWhatever((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        ((UnityEngine.ILogHandler)vc.csObj).LogFormat(arg0, arg1, arg2, arg3);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ILogHandler);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ILogHandler_LogException__Exception__UEObject, "LogException"),
        new JSMgr.MethodCallBackInfo(ILogHandler_LogFormat__LogType__UEObject__String__Object_Array, "LogFormat"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
