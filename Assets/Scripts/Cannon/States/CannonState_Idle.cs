using UnityEngine;

public class CannonState_Idle: CannonState
{
    public CannonState_Idle(Cannon controller) : base(controller)
    {

    }

    public override void OnEnter(State prevState)
    {
    }

    public override void Update()
    {
        //If player is dragging mouse and cursor is behind cannon, prepare shot
        if (m_controller.IsDragging && m_controller.IsPointBehindCannon(m_controller.CurrentMousePos))
        {
            TransitionToState(CannonStateEnum.PrepareShot);
        }
    }

    public override void OnExit(State nextState)
    {
    }
}