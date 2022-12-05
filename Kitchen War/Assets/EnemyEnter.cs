using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EnemyEnter : MonoBehaviour 
{
    public Text liveText;
	public int total = 10;

    // Start is called before the first frame update
    void Start()
    {
        //liveText = GetComponent<Text>();
        total = 10;

        
    }

    // Update is called once per frame
    void Update()
    {
       liveText.text = total.ToString();
    }

    private void OnTriggerEnter(Collider other)
        {
          
            if (other.CompareTag("Enemy"))
            
            {
            Debug.Log(" Enemy entered cookie area!");
            total -= 1;
           
            

            if (total == 0)
            {
                Debug.Log("Player is dead");
            }
            
            
            }
        }

   
  
} 

    
