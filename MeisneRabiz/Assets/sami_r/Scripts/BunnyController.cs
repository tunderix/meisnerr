using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BunnyController : MonoBehaviour {

	public GameObject bunnyPrefab;
	public GameObject levitatingTerrain; 

	//Parameters for spawning new bunnies! 
	public int quantity;
	public int thickness; 
	public float radius;

	//Parameters for handling bunnies. 
	private Bunny[] bunnies; 

	void Start () {
		SpawnBunnies ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	//Function for controlling amount/quantity of bunnies, starting position..... 
	void SpawnBunnies () {

		//Vector3[] positions = new Vector3[quantity];
		List<Vector3> positions = new List<Vector3>();

		for (int i = 0; i < quantity - 1; i++) {
			// Generate locations//vector3s --> Spawn points. 
			positions.Add(generateRandomPosition());

			//TODO!!!! 
			//Check up that we do NOT overlap with other coords. 
		}



		for (int i = 1; i < positions.Count; i++) {
			GenerateBunny(positions[i]);
		}
	}

	void GenerateBunny (Vector3 spawnPoint) {
		GameObject.Instantiate (bunnyPrefab, spawnPoint, bunnyPrefab.transform.rotation); 
	}


	//generate 3D position on top of game area! 
	Vector3 generateRandomPosition() {

		Vector3 randomPos = Random.insideUnitSphere * radius;
		//Vector3 position = levitatingTerrain.transform.position;
		randomPos.y = bunnyPrefab.transform.position.y;

		Debug.Log ("Generating random pos: " + randomPos.ToString());
		return randomPos;
	}
}
