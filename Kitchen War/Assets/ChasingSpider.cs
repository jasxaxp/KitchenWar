using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasingSpider : MonoBehaviour
{
	NavMeshAgent Enemy;
	GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
       Target = GameObject.FindWithTag("Player");
	   Enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Target.transform.position);
		Debug.Log(Target.transform.position);
		Debug.Log(Enemy.transform.position);
    }
}
