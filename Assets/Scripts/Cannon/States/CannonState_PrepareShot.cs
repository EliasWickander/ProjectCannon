using System.Collections.Generic;
using UnityEngine;

public class CannonState_PrepareShot : CannonState
{
    public CannonState_PrepareShot(Cannon controller) : base(controller)
    {

    }

    public override void OnEnter(State prevState)
    {
        StartPrepareShot();
    }

    public override void Update()
    {
        //If player either stopped dragging or went above cannon with mouse, transition to idle
        if (!m_controller.IsDragging || !m_controller.IsPointBehindCannon(m_controller.CurrentMousePos))
        {
            //Destroy prepared projectile first
            if (m_controller.PreparedProjectile != null)
            {
                m_controller.PreparedProjectile.Destroy();
                m_controller.PreparedProjectile = null;
            }
            
            TransitionToState(CannonStateEnum.Idle);
            return;
        }

        //When player lets go of mouse button, fire projectile
        if (Input.GetMouseButtonUp(0))
        {
            if (m_controller.PreparedProjectile != null)
            {
                TransitionToState(CannonStateEnum.Fire);
                return;   
            }
        }
            
        //Calculate aim direction
        m_data.CurrentAimDir = -(m_controller.CurrentMousePos - (Vector2)m_transform.position);
        m_data.CurrentAimDir.Normalize();
            
        RotateInAimDir();
        PrepareShot(m_controller.PreparedProjectile);
    }

    public override void OnExit(State nextState)
    {
        m_controller.SpriteRenderer.color = Color.white;
    }
    
    /// <summary>
    /// Spawn projectile that will be prepared
    /// </summary>
    private void StartPrepareShot()
    {
        Projectile projectilePrefab = m_data.ProjectileToSpawn.Prefab;
        
        if (projectilePrefab != null)
        {
            Projectile preparedProjectile = Object.Instantiate(projectilePrefab, m_controller.ProjectileSocket);
            preparedProjectile.Rigidbody.isKinematic = true;

            m_controller.PreparedProjectile = preparedProjectile;
        }
        else
        {
            Debug.LogWarning("Attempted to prepare a projectile, but prefab in selected projectile data is null. Click to locate", m_controller.gameObject);
        }
    }
    
    /// <summary>
    /// Prepares projectile for fire
    /// </summary>
    /// <param name="projectile">Projectile to prepare</param>
    private void PrepareShot(Projectile projectile)
    {
        DrawTrajectory(projectile);
        
        Vector2 cannonPos = m_transform.position;
        Vector2 dirToMousePos = m_controller.CurrentMousePos - cannonPos;

        float pullPercentage = Mathf.InverseLerp(0, m_data.MaxPullDist, dirToMousePos.magnitude);

        m_data.CurrentPower = Mathf.Lerp(m_data.MinPower, m_data.MaxPower, pullPercentage);

        m_controller.SpriteRenderer.color = Color.Lerp(Color.white, Color.red, pullPercentage);
    }

    /// <summary>
    /// Rotate cannon in aim direction
    /// </summary>
    private void RotateInAimDir()
    {
        float angle = Mathf.Atan2(m_data.CurrentAimDir.x, m_data.CurrentAimDir.y) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, -m_data.ClampX, m_data.ClampX);

        m_transform.rotation = Quaternion.Euler(0f, 0f, -angle);
    }

    /// <summary>
    /// Draw projectile trajectory
    /// </summary>
    /// <param name="projectile">Projectile to draw trajectory of</param>
    private void DrawTrajectory(Projectile projectile)
    {
        if(projectile == null)
            return;
        
        float travelSpeed = projectile.Data.BaseTravelSpeed * m_data.CurrentPower;
        
        List<Vector2> points = projectile.GetTrajectory(projectile.Transform.position, m_transform.up * travelSpeed, 1000);
        
        for(int i = 0; i < points.Count; i++)
        {
            if (i < points.Count - 1)
            {
                Vector2 currentPoint = points[i];
                Vector2 nextPoint = points[i + 1];
                
                Debug.DrawLine(currentPoint, nextPoint, Color.cyan);
            }
        }
    }
}