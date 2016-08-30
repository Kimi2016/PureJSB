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

public class JSB_UnityEngine_DistanceJoint2D
{

////////////////////// DistanceJoint2D ///////////////////////////////////////
// constructors

static bool DistanceJoint2D_DistanceJoint2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.DistanceJoint2D());
    }

    return true;
}

// fields

// properties
static void DistanceJoint2D_autoConfigureDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.DistanceJoint2D _this = (UnityEngine.DistanceJoint2D)vc.csObj;
        var result = _this.autoConfigureDistance;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.DistanceJoint2D _this = (UnityEngine.DistanceJoint2D)vc.csObj;
        _this.autoConfigureDistance = arg0;
    }
}
static void DistanceJoint2D_distance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.DistanceJoint2D _this = (UnityEngine.DistanceJoint2D)vc.csObj;
        var result = _this.distance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.DistanceJoint2D _this = (UnityEngine.DistanceJoint2D)vc.csObj;
        _this.distance = arg0;
    }
}
static void DistanceJoint2D_maxDistanceOnly(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.DistanceJoint2D _this = (UnityEngine.DistanceJoint2D)vc.csObj;
        var result = _this.maxDistanceOnly;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.DistanceJoint2D _this = (UnityEngine.DistanceJoint2D)vc.csObj;
        _this.maxDistanceOnly = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.DistanceJoint2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        DistanceJoint2D_autoConfigureDistance,
        DistanceJoint2D_distance,
        DistanceJoint2D_maxDistanceOnly,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(DistanceJoint2D_DistanceJoint2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
