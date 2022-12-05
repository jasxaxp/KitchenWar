using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	[SerializeField]
	private UnityEngine.UIElements.ProgressBar HealthBar;
	public int Health;

    private float MaxHealth;

	public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
		Health = 2;
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
		}
			
		if (Health <= 0)
		{
			Destroy(enemy);
			CoinSystem.total += 1;

		}
			
		

		if (collision.transform.tag == "Player")
		{
			Destroy(enemy);
        }
	}
}
