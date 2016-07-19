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

public class JSB_UnityEngine_ClothSkinningCoefficient
{

////////////////////// ClothSkinningCoefficient ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool ClothSkinningCoefficient_ClothSkinningCoefficient1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ClothSkinningCoefficient());
    }

    return true;
}

// fields
static void ClothSkinningCoefficient_maxDistance(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        var result = _this.maxDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        _this.maxDistance = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void ClothSkinningCoefficient_maxDistanceBias(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        var result = _this.maxDistanceBias;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        _this.maxDistanceBias = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void ClothSkinningCoefficient_collisionSphereRadius(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        var result = _this.collisionSphereRadius;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        _this.collisionSphereRadius = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void ClothSkinningCoefficient_collisionSphereDistance(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        var result = _this.collisionSphereDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ClothSkinningCoefficient _this = (UnityEngine.ClothSkinningCoefficient)vc.csObj;
        _this.collisionSphereDistance = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ClothSkinningCoefficient);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        ClothSkinningCoefficient_maxDistance,
        ClothSkinningCoefficient_maxDistanceBias,
        ClothSkinningCoefficient_collisionSphereRadius,
        ClothSkinningCoefficient_collisionSphereDistance,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ClothSkinningCoefficient_ClothSkinningCoefficient1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}