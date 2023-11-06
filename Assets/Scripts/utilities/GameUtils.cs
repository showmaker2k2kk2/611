using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameUtils 
{
    public static void DelayCall(this MonoBehaviour mono, float time, Action Callback)
    {
        mono.StartCoroutine(IEDelayCall(time, Callback));
    }


    public static IEnumerator IEDelayCall(float time, Action Callback)
    {
        yield return new WaitForSeconds(time);
        Callback?.Invoke();
    }


    public static T TryGetMonoComponent<T>(this MonoBehaviour mono, ref T tryValue)
    {
        if (tryValue == null)
            tryValue = mono.gameObject.GetComponent<T>();
        return tryValue;
    }
}
