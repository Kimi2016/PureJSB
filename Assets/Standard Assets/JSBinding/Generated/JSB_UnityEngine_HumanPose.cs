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

public class JSB_UnityEngine_HumanPose
{

////////////////////// HumanPose ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool HumanPose_HumanPose1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.HumanPose());
    }

    return true;
}

// fields
static void HumanPose_bodyPosition(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.HumanPose _this = (UnityEngine.HumanPose)vc.csObj;
        var result = _this.bodyPosition;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.HumanPose _this = (UnityEngine.HumanPose)vc.csObj;
        _this.bodyPosition = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanPose_bodyRotation(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.HumanPose _this = (UnityEngine.HumanPose)vc.csObj;
        var result = _this.bodyRotation;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.HumanPose _this = (UnityEngine.HumanPose)vc.csObj;
        _this.bodyRotation = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanPose_muscles(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.HumanPose _this = (UnityEngine.HumanPose)vc.csObj;
        var result = _this.muscles;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setSingle((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else {
        System.Single[] arg0 = JSDataExchangeMgr.GetJSArg<System.Single[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Single[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Single)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.HumanPose _this = (UnityEngine.HumanPose)vc.csObj;
        _this.muscles = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.HumanPose);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        HumanPose_bodyPosition,
        HumanPose_bodyRotation,
        HumanPose_muscles,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HumanPose_HumanPose1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
