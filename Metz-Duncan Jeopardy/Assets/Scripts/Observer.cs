using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NotificationType
{

};

public abstract class Observer : MonoBehaviour
{
    public abstract void OnNotify(NotificationType type);
}