using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OnWin_and_OnLose", menuName = "ScriptableObjects/OnWin_and_OnLose", order = 1)]
public class OnWin_and_OnLose : ScriptableObject
{
    public event Action OnWin;
    public event Action OnLose;
    public void ActiveOnWin()
    {
        OnWin?.Invoke();
    }
    public void ActiveOnLose()
    {
        OnLose?.Invoke();
    }

}
