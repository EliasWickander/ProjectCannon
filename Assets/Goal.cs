using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wild;

public class Goal : MonoBehaviour
{
    [SerializeField] 
    private float m_suckTime = 1;

    private Transform m_transform;

    private void Awake()
    {
        m_transform = transform;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject collidedObject = other.gameObject;
        
        if (collidedObject.layer == LayerMask.NameToLayer("Projectile"))
        {
            Projectile projectile = collidedObject.GetComponentInParent<Projectile>();

            StartCoroutine(DoSuck(projectile));
        }
    }

    private IEnumerator DoSuck(Projectile projectile)
    {
        projectile.Rigidbody.velocity = Vector2.zero;
        projectile.Rigidbody.isKinematic = true;

        float suckTimer = 0;

        Vector2 startPos = projectile.Transform.position;
        Vector2 targetPos = m_transform.position;
        Vector2 controlPoint = (startPos + targetPos) * 0.5f;

        while (suckTimer < m_suckTime)
        {
            yield return new WaitForEndOfFrame();

            Vector2 newPos = Bezier.BezierCurve(startPos, controlPoint, targetPos, CustomLerp.Lerp(suckTimer / m_suckTime, LerpMode.EaseInSine));
            projectile.Transform.position = newPos;
            suckTimer += Time.deltaTime;
        }
    }

    private Vector2 GetClosestCardinalDirection(Vector2 sample)
    {
        sample.Normalize();

        float closestDist = Mathf.NegativeInfinity;
        Vector2 closestCardinalDir = Vector2.zero;

        Vector2[] cardinalDirections = new Vector2[4] {Vector2.up, Vector2.down, Vector2.right, Vector2.left};

        foreach (Vector2 dir in cardinalDirections)
        {
            float dot = Vector2.Dot(sample, dir);

            Debug.Log(dot + " " + dir);
            
            if (dot > closestDist)
            {
                closestDist = dot;
                closestCardinalDir = dir;
            }
        }

        return closestCardinalDir;
    }
}
