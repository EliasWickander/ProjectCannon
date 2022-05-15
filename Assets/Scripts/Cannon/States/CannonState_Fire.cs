public class CannonState_Fire : CannonState
{
    public CannonState_Fire(Cannon controller) : base(controller)
    {

    }

    public override void OnEnter(State prevState)
    {
        Fire();
    }

    public override void Update()
    {
        TransitionToState(CannonStateEnum.Idle);
    }

    public override void OnExit(State nextState)
    {

    }

    /// <summary>
    /// Fires prepared projectile
    /// </summary>
    private void Fire()
    {
        Projectile preparedProjectile = m_controller.PreparedProjectile;
        
        if(preparedProjectile == null)
            return;

        preparedProjectile.Rigidbody.isKinematic = false;
        preparedProjectile.Transform.SetParent(null);
        
        preparedProjectile.Shoot(m_data);

        m_controller.PreparedProjectile = null;
    }
}