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

public class JSB_UnityEngine_CustomYieldInstruction
{

////////////////////// CustomYieldInstruction ///////////////////////////////////////
// constructors

// fields

// properties
static void CustomYieldInstruction_keepWaiting(JSVCall vc)
{
        UnityEngine.CustomYieldInstruction _this = (UnityEngine.CustomYieldInstruction)vc.csObj;
        var result = _this.keepWaiting;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void CustomYieldInstruction_Current(JSVCall vc)
{
        UnityEngine.CustomYieldInstruction _this = (UnityEngine.CustomYieldInstruction)vc.csObj;
        var result = _this.Current;
                JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
}

// methods

static bool CustomYieldInstruction_MoveNext(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.CustomYieldInstruction)vc.csObj).MoveNext()));
    }

    return true;
}

static bool CustomYieldInstruction_Reset(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.CustomYieldInstruction)vc.csObj).Reset();
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.CustomYieldInstruction);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        CustomYieldInstruction_keepWaiting,
        CustomYieldInstruction_Current,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CustomYieldInstruction_MoveNext, "MoveNext"),
        new JSMgr.MethodCallBackInfo(CustomYieldInstruction_Reset, "Reset"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
