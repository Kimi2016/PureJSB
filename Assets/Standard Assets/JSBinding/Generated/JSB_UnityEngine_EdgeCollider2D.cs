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

public class JSB_UnityEngine_EdgeCollider2D
{

////////////////////// EdgeCollider2D ///////////////////////////////////////
// constructors

static bool EdgeCollider2D_EdgeCollider2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.EdgeCollider2D());
    }

    return true;
}

// fields

// properties
static void EdgeCollider2D_edgeCount(JSVCall vc)
{
        UnityEngine.EdgeCollider2D _this = (UnityEngine.EdgeCollider2D)vc.csObj;
        var result = _this.edgeCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void EdgeCollider2D_pointCount(JSVCall vc)
{
        UnityEngine.EdgeCollider2D _this = (UnityEngine.EdgeCollider2D)vc.csObj;
        var result = _this.pointCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void EdgeCollider2D_points(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.EdgeCollider2D _this = (UnityEngine.EdgeCollider2D)vc.csObj;
        var result = _this.points;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setVector2S((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else
    { 
        UnityEngine.Vector2[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.Vector2[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.Vector2[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.EdgeCollider2D _this = (UnityEngine.EdgeCollider2D)vc.csObj;
        _this.points = arg0;
    }
}

// methods

static bool EdgeCollider2D_Reset(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.EdgeCollider2D)vc.csObj).Reset();
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.EdgeCollider2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        EdgeCollider2D_edgeCount,
        EdgeCollider2D_pointCount,
        EdgeCollider2D_points,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(EdgeCollider2D_EdgeCollider2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(EdgeCollider2D_Reset, "Reset"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
