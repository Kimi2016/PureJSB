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

public class JSB_UnityEngine_ParticleSystem_MinMaxCurve
{

////////////////////// MinMaxCurve ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool MinMaxCurve_MinMaxCurve1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem.MinMaxCurve());
    }

    return true;
}

static bool MinMaxCurve_MinMaxCurve2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem.MinMaxCurve(arg0));
    }

    return true;
}

static bool MinMaxCurve_MinMaxCurve3(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AnimationCurve arg1 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem.MinMaxCurve(arg0, arg1));
    }

    return true;
}

static bool MinMaxCurve_MinMaxCurve4(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AnimationCurve arg1 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimationCurve arg2 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem.MinMaxCurve(arg0, arg1, arg2));
    }

    return true;
}

static bool MinMaxCurve_MinMaxCurve5(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem.MinMaxCurve(arg0, arg1));
    }

    return true;
}

// fields

// properties
static void MinMaxCurve_mode(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.mode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ParticleSystemCurveMode arg0 = (UnityEngine.ParticleSystemCurveMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.mode = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_curveScalar(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.curveScalar;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.curveScalar = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_curveMax(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.curveMax;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.AnimationCurve arg0 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.curveMax = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_curveMin(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.curveMin;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.AnimationCurve arg0 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.curveMin = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_constantMax(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.constantMax;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.constantMax = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_constantMin(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.constantMin;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.constantMin = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_constant(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.constant;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.constant = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void MinMaxCurve_curve(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        var result = _this.curve;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.AnimationCurve arg0 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.MinMaxCurve _this = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;
        _this.curve = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods

static bool MinMaxCurve_Evaluate__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
UnityEngine.ParticleSystem.MinMaxCurve argThis = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(argThis.Evaluate(arg0, arg1)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool MinMaxCurve_Evaluate__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
UnityEngine.ParticleSystem.MinMaxCurve argThis = (UnityEngine.ParticleSystem.MinMaxCurve)vc.csObj;                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(argThis.Evaluate(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool MinMaxCurve_op_Implicit__Single_to_MinMaxCurve(JSVCall vc, int argc)
{
    System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.ParticleSystem.MinMaxCurve)arg0);
    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticleSystem.MinMaxCurve);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        MinMaxCurve_mode,
        MinMaxCurve_curveScalar,
        MinMaxCurve_curveMax,
        MinMaxCurve_curveMin,
        MinMaxCurve_constantMax,
        MinMaxCurve_constantMin,
        MinMaxCurve_constant,
        MinMaxCurve_curve,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(MinMaxCurve_MinMaxCurve1, ".ctor"),
        new JSMgr.MethodCallBackInfo(MinMaxCurve_MinMaxCurve2, ".ctor"),
        new JSMgr.MethodCallBackInfo(MinMaxCurve_MinMaxCurve3, ".ctor"),
        new JSMgr.MethodCallBackInfo(MinMaxCurve_MinMaxCurve4, ".ctor"),
        new JSMgr.MethodCallBackInfo(MinMaxCurve_MinMaxCurve5, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(MinMaxCurve_Evaluate__Single__Single, "Evaluate"),
        new JSMgr.MethodCallBackInfo(MinMaxCurve_Evaluate__Single, "Evaluate"),
        new JSMgr.MethodCallBackInfo(MinMaxCurve_op_Implicit__Single_to_MinMaxCurve, "op_Implicit"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
