using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Projectile", fileName = "New Projectile Data")]
public class ProjectileData : ScriptableObject
{
    [SerializeField] 
    private float m_baseTravelSpeed = 1;
    public float BaseTravelSpeed => m_baseTravelSpeed;
}
