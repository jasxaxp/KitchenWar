using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class Upgrade1 : MonoBehaviour
    
{
    public Collider m_Collider;


    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<Collider>();
    }

    void Update()
    {
        if (CoinSystem.total >= 5)
        {
            //Toggle the Collider on and off when pressing the space bar
            m_Collider.enabled = !m_Collider.enabled;
			CoinSystem.total -= 5;
        
        }
	}
}
