using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public EnemySpawner enemyspawner;
	public int enemiesToSpawn;
	private int waveCount=1;
	public int wavetoWin=4;
	public GameObject cutScene;



	// Use this for initialization
	protected void Start() {

		spawnWave();
		EnemySpawner.activated = false;
		enemiesToSpawn = waveCount * 2;
		cutScene.SetActive(false);
		return;

	}

	// Update is called once per frame
	protected void Update()
	{
		if (waveCount > wavetoWin)
        {
			enemyspawner.gameObject.SetActive(false);
			cutScene.SetActive(true);
			return;
        }


		if (enemyspawner.transform.childCount == 0 && EnemySpawner.activated)
		{
			HUD.Message("Raund: " + waveCount);
			spawnWave();
			waveCount++;
			enemiesToSpawn = Random.Range(waveCount * 3, waveCount * 7);
		}
	}


	public void spawnWave()
	{
		for (int i = 0; i < enemiesToSpawn; i++)
        {
			enemyspawner.Spawn();
        }

	}

}




