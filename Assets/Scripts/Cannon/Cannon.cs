using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Cannon : MonoBehaviour
{
    [SerializeField] 
    private CannonData m_data = null;

    public CannonData Data => m_data;

    [SerializeField] 
    private Transform m_projectileSocket = null;

    public Transform ProjectileSocket => m_projectileSocket;
    
    [SerializeField] 
    private SpriteRenderer m_spriteRenderer;

    public SpriteRenderer SpriteRenderer => m_spriteRenderer;
    
    private Camera m_camera;
    private Transform m_transform;
    public Transform Transform => m_transform;

    private Vector2 m_startDragPos = Vector3.zero;
    private Vector2 m_currentMousePos = Vector3.zero;
    public Vector2 CurrentMousePos => m_currentMousePos;
    
    private Projectile m_preparedProjectile = null;
    public Projectile PreparedProjectile
    {
        get
        {
            return m_preparedProjectile;
        }
        set
        {
            m_preparedProjectile = value;
        }
    }
    
    public bool IsDragging { get; private set; }

    private StateMachine m_stateMachine = null;

    private void Awake()
    {
        InitStateMachine();
        
        m_camera = Camera.main;
        m_transform = transform;
    }

    private void OnEnable()
    {
        if (m_data == null)
        {
            Debug.LogError("Cannon Data cannot be null. Click to locate", gameObject);
            enabled = false;
            return;
        }
        
        if (m_data.ProjectileToSpawn == null)
        {
            Debug.LogError("Projectile to spawn is null. Click to locate", gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_currentMousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        
        if(Input.GetMouseButtonDown(0))
            OnDragStart();

        IsDragging = Input.GetMouseButton(0) && Vector3.Distance(m_startDragPos, m_currentMousePos) > Data.DragDeadZone;
        
        m_stateMachine?.Update();
    }

    private void OnDragStart()
    {
        m_startDragPos = m_currentMousePos;
    }

    //Checks if point is behind cannon
    public bool IsPointBehindCannon(Vector2 point)
    {
        Vector2 dirToPoint = point - (Vector2)m_transform.position;

        return Vector2.Dot(dirToPoint, Vector2.up) < 0;
    }

    private void InitStateMachine()
    {
        Dictionary<Enum, State> states = new Dictionary<Enum, State>()
        {
            {CannonStateEnum.Idle, new CannonState_Idle(this)},
            {CannonStateEnum.PrepareShot, new CannonState_PrepareShot(this)},
            {CannonStateEnum.Fire, new CannonState_Fire(this)}
        };

        m_stateMachine = new StateMachine(states);
    }
}
