using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2 : MonoBehaviour
{
    public Collider m_Collider;

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<BoxCollider>();
		m_Collider.enabled = !m_Collider.enabled;
    }
}
