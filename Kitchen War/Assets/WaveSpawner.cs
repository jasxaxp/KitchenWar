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
	public float timeBetweenWaves;

	public Text waveCountdownText;
	public float waveCountdown;

	private float searchCountdown = 1f;

    public Text waveText;
	public int totalWaves = 1;


	private SpawnState state = SpawnState.COUNTING;

	void Start()
	{
		waveCountdown = timeBetweenWaves;
        //waveText = GetComponent<Text>();
        totalWaves = 1;
		waveCountdownText.text = timeBetweenWaves.ToString();
        
	}
    public void YouWon()
    {
        YouWonScreen.SetActive(true);
    }

	void Update()
	{
        waveText.text = totalWaves.ToString();

		waveCountdownText.text = timeBetweenWaves.ToString();



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
					Time.timeScale = 0f;
                    
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
                totalWaves = totalWaves + 1;

                if (totalWaves >= 3)
                {
                    totalWaves = 3;
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
				waveText.text = totalWaves.ToString();
                totalWaves = totalWaves + 1;
				


				if (totalWaves >= 4)
				{
					totalWaves = 3;

				}

				
				
			}
		}
		else
		{
			waveCountdown -= Time.deltaTime;
			waveCountdownText.text = waveCountdown.ToString();
			waveText.text = totalWaves.ToString();
			
		}
	}

	void WaveCompleted()
	{
        state = SpawnState.COUNTING;
		waveCountdown = timeBetweenWaves;
		waveCountdownText.text = timeBetweenWaves.ToString();

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
				waveCountdown = timeBetweenWaves;
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