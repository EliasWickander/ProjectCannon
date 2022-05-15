using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StateMachine
{
    public Dictionary<Enum, State> m_states = new Dictionary<Enum, State>();

    private State m_currentState = null;
    private Enum m_currentStateEnum = null;

    public StateMachine(Dictionary<Enum, State> states)
    {
        this.m_states = states;
        
        if(states.Count > 0)
            SetState(states.Keys.First());
    }

    public void Update()
    {
        if(m_currentState != null)
            m_currentState.Update();
        
    }

    public void SetState(Enum stateEnum)
    {
        if (!m_states.TryGetValue(stateEnum, out State newState))
            throw new Exception("Attempted to set an invalid state");

        if (m_currentState != null)
        {
            m_currentState.OnExit(newState);
            m_currentState.OnStateTransition -= SetState;
        }

        newState.OnStateTransition += SetState;
        newState.OnEnter(m_currentState);
        
        m_currentState = newState;
        m_currentStateEnum = stateEnum;
    }
}
