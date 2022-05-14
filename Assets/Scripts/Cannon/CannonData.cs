using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Cannon", fileName = "New Cannon Data")]
public class CannonData : ScriptableObject
{
    [SerializeField] 
    private float m_dragDeadZone = 0.2f;

    public float DragDeadZone => m_dragDeadZone;

    [Header("Shooting")] 
    [SerializeField] 
    private Projectile m_projectileToSpawn = null;

    public Projectile ProjectileToSpawn => m_projectileToSpawn;
    
    [SerializeField] 
    private float m_maxPullDist = 2;
    public float MaxPullDist => m_maxPullDist;
    
    [SerializeField] 
    private float m_minPower = 1;
    public float MinPower => m_minPower;
    
    [SerializeField] 
    private float m_maxPower = 3;
    public float MaxPower => m_maxPower;
    
    public Vector2 CurrentAimDir { get; set; } = Vector2.zero;
    public float CurrentPower { get; set; } = 0;
    
    [Header("Movement")]
    [SerializeField] 
    private float m_clampX = 45;
    public float ClampX => m_clampX;
    
    public bool IsAiming { get; set; } = false;

    private void OnEnable()
    {
        IsAiming = false;
        CurrentAimDir = Vector2.zero;
        CurrentPower = 0;
    }
}
