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

public class JSB_UnityEngine_SpringJoint
{

////////////////////// SpringJoint ///////////////////////////////////////
// constructors

static bool SpringJoint_SpringJoint1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.SpringJoint());
    }

    return true;
}

// fields

// properties
static void SpringJoint_spring(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        var result = _this.spring;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        _this.spring = arg0;
    }
}
static void SpringJoint_damper(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        var result = _this.damper;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        _this.damper = arg0;
    }
}
static void SpringJoint_minDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        var result = _this.minDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        _this.minDistance = arg0;
    }
}
static void SpringJoint_maxDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        var result = _this.maxDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        _this.maxDistance = arg0;
    }
}
static void SpringJoint_tolerance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        var result = _this.tolerance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SpringJoint _this = (UnityEngine.SpringJoint)vc.csObj;
        _this.tolerance = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.SpringJoint);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        SpringJoint_spring,
        SpringJoint_damper,
        SpringJoint_minDistance,
        SpringJoint_maxDistance,
        SpringJoint_tolerance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SpringJoint_SpringJoint1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
