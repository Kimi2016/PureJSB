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

public class JSB_UnityEngine_WaitForSecondsRealtime
{

////////////////////// WaitForSecondsRealtime ///////////////////////////////////////
// constructors

static bool WaitForSecondsRealtime_WaitForSecondsRealtime1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.WaitForSecondsRealtime(arg0));
    }

    return true;
}

// fields

// properties
static void WaitForSecondsRealtime_keepWaiting(JSVCall vc)
{
        UnityEngine.WaitForSecondsRealtime _this = (UnityEngine.WaitForSecondsRealtime)vc.csObj;
        var result = _this.keepWaiting;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.WaitForSecondsRealtime);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        WaitForSecondsRealtime_keepWaiting,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(WaitForSecondsRealtime_WaitForSecondsRealtime1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}