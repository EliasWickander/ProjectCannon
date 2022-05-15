using UnityEngine;

public enum CannonStateEnum
{
    Idle,
    PrepareShot,
    Fire,
}

public abstract class CannonState : State
{
    protected Cannon m_controller = null;
    protected CannonData m_data = null;
    
    protected CannonState(Cannon controller) : base(controller.gameObject)
    {
        if (controller == null)
        {
            Debug.LogError("Controller of state " + this + " is null. Something is wrong");
            return;
        }

        if (controller.Data == null)
        {
            Debug.LogError("Cannon Data of controller of state " + this + " is null. Something is wrong");
            return;
        }
        
        this.m_controller = controller;
        this.m_data = controller.Data;
    }
}