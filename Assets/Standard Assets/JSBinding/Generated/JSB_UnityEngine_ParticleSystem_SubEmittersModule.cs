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

public class JSB_UnityEngine_ParticleSystem_SubEmittersModule
{

////////////////////// SubEmittersModule ///////////////////////////////////////
// constructors

// fields

// properties
static void SubEmittersModule_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.enabled = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void SubEmittersModule_birth0(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.birth0;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.birth0 = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void SubEmittersModule_birth1(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.birth1;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.birth1 = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void SubEmittersModule_collision0(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.collision0;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.collision0 = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void SubEmittersModule_collision1(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.collision1;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.collision1 = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void SubEmittersModule_death0(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.death0;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.death0 = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void SubEmittersModule_death1(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        var result = _this.death1;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.SubEmittersModule _this = (UnityEngine.ParticleSystem.SubEmittersModule)vc.csObj;
        _this.death1 = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticleSystem.SubEmittersModule);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        SubEmittersModule_enabled,
        SubEmittersModule_birth0,
        SubEmittersModule_birth1,
        SubEmittersModule_collision0,
        SubEmittersModule_collision1,
        SubEmittersModule_death0,
        SubEmittersModule_death1,

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
