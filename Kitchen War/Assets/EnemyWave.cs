using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
	public GameObject enemy;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	
	public bool Go = false;
	GameObject tempEnemy;
	public int total;
	
    // Start is called before the first frame update
    void Start()
    {
		total = 0;
    }

    // Update is called once per frame
    void Update()
    {
		if (Go == false)
		{
			StartCoroutine(Enemies());
		}
    }
	
	IEnumerator Enemies()
	{
		Go = true;
		if (total == 0)
		{
			enemy.SetActive(true);
		}
		else if (total == 1)
		{
			enemy1.SetActive(true);
		}
		else if (total == 2)
		{
			enemy2.SetActive(true);
		}
		else if (total == 3)
		{
			enemy3.SetActive(true);
		}
		else if (total == 4)
		{
			enemy4.SetActive(true);
		}
		else if (total == 5)
		{
			enemy5.SetActive(true);
		}
		total += 1;
		yield return new WaitForSeconds(2f);
		Go = false;
	}
}





