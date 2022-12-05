using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour 
{
	public enum SpawnState { SPAWNING, WAITING, COUNTING, FINISHED};
	[System.Serializable]
	public class Wave
	{
		public string name;
		public Transform enemy;
		public int count;
		public float rate;
	}
    public GameObject YouWonScreen;

	public Transform[] spawnPoints;

	public Wave[] waves;
	private int nextWave = 0;
	public float timeBetweenWaves = 5f;
	public float waveCountdown;

	private float searchCountdown = 1f;

    public Text waveText;
	public int total = 1;

	private SpawnState state = SpawnState.COUNTING;

	void Start()
	{
		waveCountdown = timeBetweenWaves;
        //waveText = GetComponent<Text>();
        total = 1;
        
	}
    public void YouWon()
    {
        YouWonScreen.SetActive(true);
    }

	void Update()
	{
        waveText.text = total.ToString();

        if  (state == SpawnState.FINISHED) 
        {
            if (nextWave >= 2)
            {
                Debug.Log("ALL WAVES COMPLETED!");
                state = SpawnState.FINISHED;
                
                
                
                if (GameObject.FindGameObjectWithTag ("Enemy") == null)
                {
                    Debug.Log("Player Won!");
                    YouWon();
                    
                }
            }
          return;
            
        }

		if (state == SpawnState.WAITING)
		{
			// Checking if enemies are still alive
			if (!EnemyIsAlive())
			{
				// Begin a new round
				Debug.Log(" This wave is completed!");
                nextWave++;
                total = total + 1;

                if (total >= 3)
                {
                    total = 3;
                    state = SpawnState.FINISHED;
                  
                   
                    

                }
                
                //return;
	
			}
			else
			{
				return;
			}
		}

		if (waveCountdown <= 0)
		{
			if (state != SpawnState.SPAWNING)
			{
				StartCoroutine(SpawnWave(waves[nextWave]));
                total = 2;
			}
		}
		else
		{
			waveCountdown -= Time.deltaTime;
		}
	}

	void WaveCompleted()
	{
        state = SpawnState.COUNTING;
		waveCountdown = timeBetweenWaves;

		if (nextWave + 1 > waves.Length - 1)
		{
			state = SpawnState.FINISHED;
			Debug.Log("ALL WAVES COMPLETED!");
            
            //if (GameObject.FindGameObjectWithTag ("Enemy") == null)
            //{
            //    Debug.Log("Player Won!");
                
                
          //  }
		}
		else
		{
			nextWave++;
		}
	}

			

	bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag ("Enemy") == null)
            {
                return false;
            }
        }
            return true;
     }

	IEnumerator SpawnWave(Wave _wave)
	{
		Debug.Log("" + _wave.name);
		state = SpawnState.SPAWNING;

		for (int i = 0; i < _wave.count; i++)
		{
			SpawnEnemy(_wave.enemy);
			yield return new WaitForSeconds( 1f/_wave.rate );

		}

		// Spawn
		state = SpawnState.WAITING;

		yield break;
	}

	void SpawnEnemy(Transform _enemy)
	{
		Instantiate(_enemy, transform.position, transform.rotation);

		//Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

		Debug.Log("Spawning Enemy: " + _enemy.name);

	}
}