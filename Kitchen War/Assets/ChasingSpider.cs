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
       Target = GameObject.FindWithTag("Cookies");
	   Enemy = GetComponent<NavMeshAgent>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Target.transform.position);

    }
    
}
