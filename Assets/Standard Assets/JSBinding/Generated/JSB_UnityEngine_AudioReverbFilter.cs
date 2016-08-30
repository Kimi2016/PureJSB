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

public class JSB_UnityEngine_AudioReverbFilter
{

////////////////////// AudioReverbFilter ///////////////////////////////////////
// constructors

static bool AudioReverbFilter_AudioReverbFilter1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AudioReverbFilter());
    }

    return true;
}

// fields

// properties
static void AudioReverbFilter_reverbPreset(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.reverbPreset;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.AudioReverbPreset arg0 = (UnityEngine.AudioReverbPreset)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.reverbPreset = arg0;
    }
}
static void AudioReverbFilter_dryLevel(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.dryLevel;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.dryLevel = arg0;
    }
}
static void AudioReverbFilter_room(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.room;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.room = arg0;
    }
}
static void AudioReverbFilter_roomHF(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.roomHF;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.roomHF = arg0;
    }
}
static void AudioReverbFilter_roomRolloff(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.roomRolloff;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.roomRolloff = arg0;
    }
}
static void AudioReverbFilter_decayTime(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.decayTime;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.decayTime = arg0;
    }
}
static void AudioReverbFilter_decayHFRatio(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.decayHFRatio;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.decayHFRatio = arg0;
    }
}
static void AudioReverbFilter_reflectionsLevel(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.reflectionsLevel;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.reflectionsLevel = arg0;
    }
}
static void AudioReverbFilter_reflectionsDelay(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.reflectionsDelay;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.reflectionsDelay = arg0;
    }
}
static void AudioReverbFilter_reverbLevel(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.reverbLevel;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.reverbLevel = arg0;
    }
}
static void AudioReverbFilter_reverbDelay(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.reverbDelay;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.reverbDelay = arg0;
    }
}
static void AudioReverbFilter_diffusion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.diffusion;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.diffusion = arg0;
    }
}
static void AudioReverbFilter_density(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.density;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.density = arg0;
    }
}
static void AudioReverbFilter_hfReference(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.hfReference;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.hfReference = arg0;
    }
}
static void AudioReverbFilter_roomLF(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.roomLF;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.roomLF = arg0;
    }
}
static void AudioReverbFilter_lfReference(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        var result = _this.lfReference;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AudioReverbFilter _this = (UnityEngine.AudioReverbFilter)vc.csObj;
        _this.lfReference = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AudioReverbFilter);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AudioReverbFilter_reverbPreset,
        AudioReverbFilter_dryLevel,
        AudioReverbFilter_room,
        AudioReverbFilter_roomHF,
        AudioReverbFilter_roomRolloff,
        AudioReverbFilter_decayTime,
        AudioReverbFilter_decayHFRatio,
        AudioReverbFilter_reflectionsLevel,
        AudioReverbFilter_reflectionsDelay,
        AudioReverbFilter_reverbLevel,
        AudioReverbFilter_reverbDelay,
        AudioReverbFilter_diffusion,
        AudioReverbFilter_density,
        AudioReverbFilter_hfReference,
        AudioReverbFilter_roomLF,
        AudioReverbFilter_lfReference,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AudioReverbFilter_AudioReverbFilter1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
