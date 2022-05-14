using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] 
    private ProjectileData m_data;

    private float m_travelSpeedMultiplier = 1;

    private bool m_isTravelling = false;

    private void OnEnable()
    {
        if (m_data == null)
        {
            Debug.LogError("Projectile Data cannot be null. Click to locate", gameObject);
            enabled = false;
            return;
        }
    }

    private void Update()
    {
        if(m_isTravelling == false)
            return;
        
        float travelSpeed = m_data.BaseTravelSpeed * m_travelSpeedMultiplier;
        
        transform.position += transform.up * travelSpeed * Time.deltaTime;
    }

    public void StartFire(CannonData shooter)
    {
        m_travelSpeedMultiplier = shooter.CurrentPower;

        m_isTravelling = true;
    }
}
