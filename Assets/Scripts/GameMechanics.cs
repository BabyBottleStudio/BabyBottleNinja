using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMechanics : MonoBehaviour
{
	public GameObject thePlayer;
	public GameObject[] enemySpawn;
	private bool gameOverBool;
	public float startWait;
	public float waveWait;
	public GameObject[] SpawnPlaces;

	public bool isGameOver = true;

	// Start is called before the first frame update
	void Start()
	{
		StartCoroutine(SpawnEnemies());


		//playerLives =  player.GetComponent<PlayerHealth>().lives;
	}

	// Update is called once per frame
	void Update()
	{
		gameOverBool = thePlayer.GetComponent<PlayerHealth>().gameOver;
	}




	// spawning of the enemies
	IEnumerator SpawnEnemies()
	{
		yield return new WaitForSeconds(startWait);
		while (true)
		{
			foreach (GameObject obj in SpawnPlaces)
			{
				float offsetZ = Random.Range(-1.6f, 1.6f);
				Vector3 spawnPos = obj.transform.position + new Vector3(0f, 0f, offsetZ);
				Quaternion spawnRot = obj.transform.rotation;

				int theIndex = Random.Range(0, 4);
				Instantiate(enemySpawn[theIndex], spawnPos, spawnRot);


			}
			yield return new WaitForSeconds(waveWait);

			if (gameOverBool)
			{
				break;
			}

		}
	}



	//GameOver

}
