using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<Observer> observers = new List<Observer>();

    public void AddObserver(Observer newObserver)
    {
        observers.Add(newObserver);
    }

    public void Notify(NotificationType type)
    {
        foreach(Observer watchdog in observers)
        {
            watchdog.OnNotify(type);
        }
    }
}
