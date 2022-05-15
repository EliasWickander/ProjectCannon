using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLerpTest : MonoBehaviour
{
    public LerpMode m_mode;
    public Vector3 m_endPointOffset = new Vector3(0, 0, 10);

    private Vector3 m_startPoint;

    private float m_lerpDuration = 2;
    private float m_elapsedTime = 0;

    private bool m_canMove = true;
    
    void Start()
    {
        m_startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_canMove)
        {
            if (m_elapsedTime < m_lerpDuration)
            {
                Vector3 newPos = Vector3.zero;

                newPos = CustomLerp.Lerp(m_startPoint, m_startPoint + m_endPointOffset, m_elapsedTime / m_lerpDuration, m_mode);
                
                transform.position = newPos;
            
                m_elapsedTime += Time.deltaTime;
            }
            else
            {
                transform.position = m_startPoint + m_endPointOffset;
                m_elapsedTime = 0;
                m_canMove = false;

                StartCoroutine(ResetTest());
            }   
        }
    }

    private IEnumerator ResetTest()
    {
        yield return new WaitForSeconds(1);
        transform.position = m_startPoint;
        m_canMove = true;
    }
}
