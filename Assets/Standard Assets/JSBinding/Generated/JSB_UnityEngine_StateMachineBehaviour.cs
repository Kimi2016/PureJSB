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
using UnityEngine.Experimental.Director;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_StateMachineBehaviour
{

////////////////////// StateMachineBehaviour ///////////////////////////////////////
// constructors

// fields

// properties

// methods

static bool StateMachineBehaviour_OnStateEnter__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateEnter(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateEnter__Animator__AnimatorStateInfo__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateEnter(arg0, arg1, arg2);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateExit__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateExit(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateExit__Animator__AnimatorStateInfo__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateExit(arg0, arg1, arg2);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateIK__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateIK(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateIK__Animator__AnimatorStateInfo__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateIK(arg0, arg1, arg2);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateMachineEnter__Animator__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg2 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateMachineEnter(arg0, arg1, arg2);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateMachineEnter__Animator__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateMachineEnter(arg0, arg1);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateMachineExit__Animator__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg2 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateMachineExit(arg0, arg1, arg2);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateMachineExit__Animator__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateMachineExit(arg0, arg1);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateMove__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateMove(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateMove__Animator__AnimatorStateInfo__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateMove(arg0, arg1, arg2);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateUpdate__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateUpdate(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool StateMachineBehaviour_OnStateUpdate__Animator__AnimatorStateInfo__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Animator arg0 = (UnityEngine.Animator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.StateMachineBehaviour)vc.csObj).OnStateUpdate(arg0, arg1, arg2);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.StateMachineBehaviour);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateEnter__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable, "OnStateEnter"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateEnter__Animator__AnimatorStateInfo__Int32, "OnStateEnter"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateExit__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable, "OnStateExit"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateExit__Animator__AnimatorStateInfo__Int32, "OnStateExit"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateIK__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable, "OnStateIK"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateIK__Animator__AnimatorStateInfo__Int32, "OnStateIK"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateMachineEnter__Animator__Int32__AnimatorControllerPlayable, "OnStateMachineEnter"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateMachineEnter__Animator__Int32, "OnStateMachineEnter"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateMachineExit__Animator__Int32__AnimatorControllerPlayable, "OnStateMachineExit"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateMachineExit__Animator__Int32, "OnStateMachineExit"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateMove__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable, "OnStateMove"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateMove__Animator__AnimatorStateInfo__Int32, "OnStateMove"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateUpdate__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable, "OnStateUpdate"),
        new JSMgr.MethodCallBackInfo(StateMachineBehaviour_OnStateUpdate__Animator__AnimatorStateInfo__Int32, "OnStateUpdate"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}