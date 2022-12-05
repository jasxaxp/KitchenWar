using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{


	
	public int Health = 2;


   
	public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		
        
    }


	
	void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.tag == "Bullet")
		{
			Health -= 1;
			Debug.Log("Enemy was hit!");
			
		}
			
		if (Health <= 0)
		{
			Destroy(enemy);
			CoinSystem.total += 1;
			Debug.Log("Enemy is dead!");

		}

		if (collision.transform.tag == "Player")
		{	
			Destroy(enemy);
			
        }
	}
}
