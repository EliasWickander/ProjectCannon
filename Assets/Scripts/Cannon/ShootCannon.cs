using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannon : MonoBehaviour
{
    [SerializeField] 
    private CannonData m_cannonData = null;

    [SerializeField] 
    private Transform m_projectileSocket = null;
    
    [SerializeField] 
    private SpriteRenderer m_spriteRenderer;

    private Camera m_camera;
    private Transform m_transform;

    private Vector2 m_startDragPos = Vector3.zero;
    private Vector2 m_currentMousePos = Vector3.zero;

    private Projectile m_preparedProjectile = null;

    private void Awake()
    {
        m_camera = Camera.main;
        m_transform = transform;
    }

    private void OnEnable()
    {
        if (m_cannonData == null)
        {
            Debug.LogError("Cannon Data cannot be null. Click to locate", gameObject);
            enabled = false;
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_currentMousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
            OnDragStart();
        
        if(Input.GetMouseButtonUp(0))
            OnDragEnd();

        if (Input.GetMouseButton(0))
        {
            if(Vector3.Distance(m_startDragPos, m_currentMousePos) > m_cannonData.DragDeadZone)
             OnDrag();   
        }
    }

    private void OnDragStart()
    {
        m_startDragPos = m_currentMousePos;
    }
    
    private void OnDragEnd()
    {
        if (m_cannonData.IsAiming)
            Fire();

        m_cannonData.CurrentAimDir = Vector2.zero;
        m_cannonData.CurrentPower = 0;
        m_cannonData.IsAiming = false;
        m_spriteRenderer.color = Color.white;
        m_preparedProjectile = null;
    }

    private void OnDrag()
    {
        m_cannonData.IsAiming = IsPointBehindCannon(m_currentMousePos);

        if (m_cannonData.IsAiming)
        {
            if (m_preparedProjectile == null)
            {
                m_preparedProjectile = Instantiate(m_cannonData.ProjectileToSpawn, m_projectileSocket);
                m_preparedProjectile.Rigidbody.isKinematic = true;
            }
            
            m_cannonData.CurrentAimDir = -(m_currentMousePos - (Vector2)m_transform.position);
            m_cannonData.CurrentAimDir.Normalize();
            
            RotateInAimDir();
            PrepareShot();
        }
    }

    private void PrepareShot()
    {
        DrawTrajectory(m_preparedProjectile);
        Vector2 cannonPos = m_transform.position;
        Vector2 dirToMousePos = m_currentMousePos - cannonPos;

        float pullPercentage = Mathf.InverseLerp(0, m_cannonData.MaxPullDist, dirToMousePos.magnitude);

        m_cannonData.CurrentPower = Mathf.Lerp(m_cannonData.MinPower, m_cannonData.MaxPower, pullPercentage);

        m_spriteRenderer.color = Color.Lerp(Color.white, Color.red, pullPercentage);
    }

    private void Fire()
    {
        if(m_preparedProjectile == null)
            return;

        m_preparedProjectile.Rigidbody.isKinematic = false;
        m_preparedProjectile.Transform.SetParent(null);
        m_preparedProjectile.Shoot(m_cannonData);
    }
    
    private void RotateInAimDir()
    {
        float angle = Mathf.Atan2(m_cannonData.CurrentAimDir.x, m_cannonData.CurrentAimDir.y) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, -m_cannonData.ClampX, m_cannonData.ClampX);

        transform.rotation = Quaternion.Euler(0f, 0f, -angle);
    }
    
    //Checks if point is behind cannon
    private bool IsPointBehindCannon(Vector2 point)
    {
        Vector2 dirToPoint = point - (Vector2)m_transform.position;

        return Vector2.Dot(dirToPoint, Vector2.up) < 0;
    }
    
    private void DrawTrajectory(Projectile projectile)
    {
        if(projectile == null)
            return;
        
        float travelSpeed = projectile.Data.BaseTravelSpeed * m_cannonData.CurrentPower;
        
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
