using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected GameObject m_controller = null;
    protected Transform m_transform = null;

    public event Action<Enum> OnStateTransition;
    
    public State(GameObject controller)
    {
        if (controller == null)
        {
            Debug.LogWarning("Controller of state " + this + " is null. Something is wrong");
            return;
        }
        
        this.m_controller = controller;
        this.m_transform = m_controller.transform;
    }

    public abstract void OnEnter(State prevState);
    public abstract void Update();
    public abstract void OnExit(State nextState);

    protected void TransitionToState(Enum state)
    {
        OnStateTransition?.Invoke(state);
    }
}