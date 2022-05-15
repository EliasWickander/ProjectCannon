using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile : MonoBehaviour
{
    [SerializeField] 
    private LayerMask m_obstacleMask;
    
    [SerializeField]
    private ProjectileData m_data;

    public ProjectileData Data => m_data;

    [SerializeField] 
    private Collider2D m_collider;
    
    private Rigidbody2D m_rigidbody;
    public Rigidbody2D Rigidbody => m_rigidbody;
    private Transform m_transform;
    public Transform Transform => m_transform;

    private Vector2 m_velocityLastFrame = Vector2.zero;

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
        m_transform = transform;
    }

    private void OnEnable()
    {
        if (m_data == null)
        {
            Debug.LogError("Projectile Data cannot be null. Click to locate", gameObject);
            enabled = false;
            return;
        }
    }

    private void LateUpdate()
    {
        m_velocityLastFrame = m_rigidbody.velocity;
    }

    public void Shoot(CannonData shooter)
    {
        float travelSpeed = m_data.BaseTravelSpeed * shooter.CurrentPower;

        m_rigidbody.AddForce(transform.up * travelSpeed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            ContactPoint2D contact = other.GetContact(0);
            Vector2 contactPoint = contact.point;
            Vector2 contactNormal = contact.normal;
            
            Vector2 dirToContactPoint = contactPoint - (Vector2)m_transform.position;
            dirToContactPoint.Normalize();
            
            Vector2 bounceDir = Vector2.Reflect(m_velocityLastFrame.normalized, contactNormal);
            bounceDir.Normalize();
            
            Debug.DrawRay(contactPoint, bounceDir, Color.green, 5);

            m_rigidbody.velocity = bounceDir * m_velocityLastFrame.magnitude;
        }
    }

    public List<Vector2> GetTrajectory(Vector2 pos, Vector2 velocity, int maxSteps)
    {
        List<Vector2> points = new List<Vector2>();
 
        float timestep = Time.fixedDeltaTime / Physics2D.velocityIterations;
        Vector2 gravityAccel = Physics2D.gravity * m_rigidbody.gravityScale * timestep * timestep;
        float drag = 1f - timestep * m_rigidbody.drag;
        Vector2 moveStep = velocity * timestep;
 
        for (int i = 0; i < maxSteps; ++i)
        {
            moveStep += gravityAccel;
            moveStep *= drag;
            pos += moveStep;

            if (CheckIfPointBlocked(pos, moveStep.normalized, out RaycastHit2D hit))
            {
                Vector2 bounceVector = Vector2.Reflect((moveStep / timestep), hit.normal);
                List<Vector2> bounceTrajectory = GetTrajectory(pos, bounceVector, maxSteps);
                
                points.AddRange(bounceTrajectory);
                break;
            }
            points.Add(pos);
        }
 
        return points;
    }

    private bool CheckIfPointBlocked(Vector2 position, Vector2 velocity, out RaycastHit2D hit)
    {
        float radius = m_collider.bounds.extents.x;

        hit = Physics2D.CircleCast(position, radius, velocity, radius, m_obstacleMask);
        
        return hit.collider != null;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
