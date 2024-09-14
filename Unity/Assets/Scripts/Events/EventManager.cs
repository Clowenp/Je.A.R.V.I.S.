using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static Action<string> OnCustomEvent;

    public static void TriggerEvent(string eventName)
    {
        OnCustomEvent?.Invoke(eventName);
    }
}
