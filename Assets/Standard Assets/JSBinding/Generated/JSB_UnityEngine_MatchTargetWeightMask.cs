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

public class JSB_UnityEngine_MatchTargetWeightMask
{

////////////////////// MatchTargetWeightMask ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool MatchTargetWeightMask_MatchTargetWeightMask1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.MatchTargetWeightMask());
    }

    return true;
}

static bool MatchTargetWeightMask_MatchTargetWeightMask2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.MatchTargetWeightMask(arg0, arg1));
    }

    return true;
}

// fields

// properties
static void MatchTargetWeightMask_positionXYZWeight(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.MatchTargetWeightMask _this = (UnityEngine.MatchTargetWeightMask)vc.csObj;
        var result = _this.positionXYZWeight;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.MatchTargetWeightMask _this = (UnityEngine.MatchTargetWeightMask)vc.csObj;
        _this.positionXYZWeight = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MatchTargetWeightMask_rotationWeight(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.MatchTargetWeightMask _this = (UnityEngine.MatchTargetWeightMask)vc.csObj;
        var result = _this.rotationWeight;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.MatchTargetWeightMask _this = (UnityEngine.MatchTargetWeightMask)vc.csObj;
        _this.rotationWeight = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.MatchTargetWeightMask);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        MatchTargetWeightMask_positionXYZWeight,
        MatchTargetWeightMask_rotationWeight,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(MatchTargetWeightMask_MatchTargetWeightMask1, ".ctor"),
        new JSMgr.MethodCallBackInfo(MatchTargetWeightMask_MatchTargetWeightMask2, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
