using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
	public GameObject enemy;
	public bool Go = false;
	GameObject Target;
	UnityEngine.AI.NavMeshAgent Enemy;
    // Start is called before the first frame update
    void Start()
    {
       Target = GameObject.FindWithTag("Cookies");
	   Enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
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
		GameObject tempEnemy = Instantiate(enemy);
		tempEnemy.SetDestination(Target.transform.position);
		yield return new WaitForSeconds(0.8f);
		Go = false;
	}
}
