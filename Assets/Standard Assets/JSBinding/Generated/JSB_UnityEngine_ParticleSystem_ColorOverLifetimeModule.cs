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

public class JSB_UnityEngine_ParticleSystem_ColorOverLifetimeModule
{

////////////////////// ColorOverLifetimeModule ///////////////////////////////////////
// constructors

// fields

// properties
static void ColorOverLifetimeModule_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.ColorOverLifetimeModule _this = (UnityEngine.ParticleSystem.ColorOverLifetimeModule)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.ColorOverLifetimeModule _this = (UnityEngine.ParticleSystem.ColorOverLifetimeModule)vc.csObj;
        _this.enabled = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void ColorOverLifetimeModule_color(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.ColorOverLifetimeModule _this = (UnityEngine.ParticleSystem.ColorOverLifetimeModule)vc.csObj;
        var result = _this.color;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem.MinMaxGradient arg0 = (UnityEngine.ParticleSystem.MinMaxGradient)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.ColorOverLifetimeModule _this = (UnityEngine.ParticleSystem.ColorOverLifetimeModule)vc.csObj;
        _this.color = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticleSystem.ColorOverLifetimeModule);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ColorOverLifetimeModule_enabled,
        ColorOverLifetimeModule_color,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
