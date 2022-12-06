using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EnemyEnter : MonoBehaviour 
{
    public Text liveText;
	public int totalLives = 10;

    public GameObject GameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        //liveText = GetComponent<Text>();
        totalLives = 10;

        
    }

    // Update is called once per frame
    void Update()
    {
       liveText.text = totalLives.ToString();
    }

    public void GameOver ()
    {
        GameOverScreen.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
        {
          
            if (other.CompareTag("Enemy"))
            
            {
            Debug.Log(" Enemy entered cookie area!");
            totalLives -= 1;
           
            

            if (totalLives == 0)
            {
                Debug.Log("Player is dead");
                GameOver();
                Time.timeScale = 0f;
            }
            
            
            }
        }

   
  
} 

    
